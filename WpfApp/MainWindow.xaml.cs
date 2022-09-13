using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DAL;
using DAL.DataTypes.Constants;
using DAL.DataTypes.Enums;
using DAL.Models;
using DAL.Repositories;
using DAL.Services;
using WpfApp.Model;
using WpfApp.UserControls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Setting _settings;
        private IRepository _repository;
        private IList<Team> _allTeams;
        private IList<Team> _opponents;
        private Team _favoritTeam;
        private Team _opponentTeam;
        private IList<Match> _allMatches;
        private IList<Match> _favoritTeamMatches;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            InitSetup();
        }

        private void MenuItemSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsViewModel settingsViewModel = new SettingsViewModel
            {
                SelectedGender = _settings.Gender,
                SelectedLang = _settings.Lang,
                SelectedTeam = _settings.FavoritTeam,
                SelectedResolution = _settings.Resolution
            };

            ChangeSettings(settingsViewModel);
        }

        private void MenuItemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window closingWindow = new ClosingWindow();
            var formClose = closingWindow.ShowDialog();
            if (formClose == false)
            {
                e.Cancel = true;
            }
        }

        private void CmbFirstTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFirstTeam.SelectedValue != null)
            {
                _opponentTeam = null;
                _settings.FavoritTeam = cmbFirstTeam.SelectedValue.ToString().Substring(0, cmbFirstTeam.SelectedValue.ToString().LastIndexOf(' '));
                Task task = SetComboboxAsync(false);
                ClearFootballField();
            }
        }

        private void CmbSecondTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cmbSecondTeam.SelectedValue != null) 
            {
                string opponentTeam = cmbSecondTeam.SelectedValue.ToString().Substring(0, cmbSecondTeam.SelectedValue.ToString().LastIndexOf(' '));

                if (opponentTeam != null)
                {
                    _opponentTeam = _allTeams.Where(x => x.Country.Contains(opponentTeam)).FirstOrDefault();
                    ClearFootballField();
                    SetFootballField();
                }
            }
        }

        private void SetFootballField()
        {
            Match match = _favoritTeamMatches.Where(x => x.HomeTeamCountry.Contains(_favoritTeam.Country) && x.AwayTeamCountry.Contains(_opponentTeam.Country)).FirstOrDefault();
            if (match != null)
            {
                SetTeamOnFootballField(CreatePlayerControls(match.HomeTeamStatistics.StartingEleven), true);
                SetTeamOnFootballField(CreatePlayerControls(match.AwayTeamStatistics.StartingEleven), false);

                return;
            }

            match = _favoritTeamMatches.Where(x => x.HomeTeamCountry.Contains(_opponentTeam.Country) && x.AwayTeamCountry.Contains(_favoritTeam.Country)).FirstOrDefault();
            SetTeamOnFootballField(CreatePlayerControls(match.HomeTeamStatistics.StartingEleven), false);
            SetTeamOnFootballField(CreatePlayerControls(match.AwayTeamStatistics.StartingEleven), true);
        }

        private void SetTeamOnFootballField(List<PlayerControl> players, bool homeTeam)
        {
            PlayerControl goalie = players.Where(x => x.Player.Position == Position.Goalie).FirstOrDefault();
            List<PlayerControl> defenders = players.Where(x => x.Player.Position == Position.Defender).ToList();
            List<PlayerControl> midfield = players.Where(x => x.Player.Position == Position.Midfield).ToList();
            List<PlayerControl> forward = players.Where(x => x.Player.Position == Position.Forward).ToList();

            fieldGrid.Children.Add(goalie);

            if (homeTeam)
            {
                Grid.SetColumn(goalie, 3);
                Grid.SetRow(goalie, 1);

                AddPlayerControlsToFieldGrid(defenders, 2);
                AddPlayerControlsToFieldGrid(midfield, 3);
                AddPlayerControlsToFieldGrid(forward, 4);
            } else
            {
                Grid.SetColumn(goalie, 3);
                Grid.SetRow(goalie, 9);

                AddPlayerControlsToFieldGrid(defenders, 8);
                AddPlayerControlsToFieldGrid(midfield, 7);
                AddPlayerControlsToFieldGrid(forward, 6);
            }
        }

        private void AddPlayerControlsToFieldGrid(List<PlayerControl> playerControls, int column)
        {
            int startingRow = 0;
            switch (playerControls.Count)
            {
                case 1:
                    startingRow = 3;
                    break;
                case 2:
                    startingRow = 2;
                    break;
                case 3:
                    startingRow = 2;
                    break;
                case 4:
                    startingRow = 1;
                    break;
                case 5:
                    startingRow = 1;
                    break;
                default:
                    startingRow = 0;
                    break;
            }

            for (int i = 0; i < playerControls.Count; i++)
            {
                fieldGrid.Children.Add(playerControls[i]);
                Grid.SetRow(playerControls[i], column);
                Grid.SetColumn(playerControls[i], startingRow);
                startingRow++;
            }
        }

        private void ClearFootballField()
        {
            fieldGrid.Children.Clear();
        }

        private void BtnDetailsFirstTeam_Click(object sender, RoutedEventArgs e)
        {
            TeamDetailsViewModel teamDetailsViewModel = new TeamDetailsViewModel
            {
                TeamResults = _favoritTeam
            };

            Window teamDetailsWindow = new TeamDetailsWindow(teamDetailsViewModel);
            teamDetailsWindow.ShowDialog();
        }

        private void BtnDetailsSecondTeam_Click(object sender, RoutedEventArgs e)
        {
            if (_opponentTeam != null)
            {
                TeamDetailsViewModel teamDetailsViewModel = new TeamDetailsViewModel
                {
                    TeamResults = _opponentTeam
                };

                Window teamDetailsWindow = new TeamDetailsWindow(teamDetailsViewModel);
                teamDetailsWindow.ShowDialog();
            }
        }

        private async Task GetData()
        {
            _opponents = new List<Team>();
            _allTeams = await _repository.GetTeamData();
            _favoritTeam = _allTeams.Where(x => x.Country.Contains(_settings.FavoritTeam)).FirstOrDefault();

            _allMatches = await _repository.GetTeamMatchesData();
            _favoritTeamMatches = _allMatches.Where(x => x.HomeTeamCountry.Contains(_settings.FavoritTeam) || x.AwayTeamCountry.Contains(_settings.FavoritTeam)).ToList();

            foreach (Match favoritTeamMatche in _favoritTeamMatches)
            {
                Team team = new Team();

                if (favoritTeamMatche.HomeTeamCountry != _favoritTeam.Country)
                {
                    team = _allTeams.Where(x => x.Country.Contains(favoritTeamMatche.HomeTeamCountry)).First();
                }
                else if (favoritTeamMatche.AwayTeamCountry != _favoritTeam.Country)
                {
                    team = _allTeams.Where(x => x.Country.Contains(favoritTeamMatche.AwayTeamCountry)).First();

                }
                _opponents.Add(team);
            }
        }

        private void ChangeSettings(SettingsViewModel settingsViewModel)
        {
            Window settingsWindow = new SettingsWindow(settingsViewModel);
            var settingsChanged = settingsWindow.ShowDialog();

            if (settingsChanged == true)
            {
                InitSetup();
            }
        }

        private void InitSetup()
        {
            SetSettings();
            SetResolution();
            SetRepository();
            Task task = SetComboboxAsync(true);

            cmbFirstTeam.SelectionChanged += new SelectionChangedEventHandler(CmbFirstTeam_SelectionChanged);
            cmbSecondTeam.SelectionChanged += new SelectionChangedEventHandler(CmbSecondTeam_SelectionChanged);
        }

        private void SetSettings()
        {
            if (!FileService.FileExist())
            {
                FileService.CopySettingsFile(Paths.WF_SETTINGS, Paths.WPF_SETTINGS);
            }

            _settings = FileService.ReadSettingsFile();
        }

        private void SetResolution()
        {
            switch (_settings.Resolution)
            {
                case Resolution.Small:
                    WindowState = WindowState.Normal;
                    Height = 900;
                    Width = 1200;
                    break;
                case Resolution.Medium:
                    WindowState = WindowState.Normal;
                    Height = 1050;
                    Width = 1400;
                    break;
                case Resolution.Large:
                    WindowState = WindowState.Normal;
                    Height = 1200;
                    Width = 1600;
                    break;
                case Resolution.Fullscreen:
                    WindowState = WindowState.Maximized;
                    break;
                default:
                    WindowState = WindowState.Normal;
                    Height = 900;
                    Width = 1200;
                    break;
            }
        }
     
        private void SetRepository()
        {
            try
            {
                _repository = RepositoryFactory.GetRepository(_settings.Gender);
            }
            catch (Exception)
            {
                //AlertBox.Show(AlertType.Error);
            }
        }

        private async Task SetComboboxAsync(bool first)
        {
            await GetData();

            if (first)
            {
                cmbFirstTeam.ItemsSource = _allTeams;
                cmbFirstTeam.SelectedIndex = _allTeams.IndexOf(_favoritTeam);
            }

            cmbSecondTeam.ItemsSource = _opponents;
            cmbSecondTeam.SelectedIndex = -1;
        }

        private List<PlayerControl> CreatePlayerControls(List<Player> playerModels)
        {
            List<PlayerControl> playerControls = new List<PlayerControl>();

            foreach (var player in playerModels)
            {
                playerControls.Add(new PlayerControl { Player = player });
            }
            return playerControls;
        }
    }
}
