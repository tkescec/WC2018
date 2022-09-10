using DAL;
using DAL.DataTypes.Enums;
using DAL.Models;
using DAL.Repositories;
using DAL.Services;
using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp.Views
{
    public sealed partial class PlayersRankView : BaseView
    {
        #region Private fields
        private readonly PlayersRankViewModel _model;
        #endregion

        #region Ctor
        public PlayersRankView(PlayersRankViewModel model = null, Loading loading = null, IRepository repository = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new PlayersRankViewModel();
            }

            if (loading != null)
            {
                _loading = loading;
            }
            else
            {
                _loading = new Loading();
            }

            if (repository != null)
            {
                _repository = repository;
            }
            else
            {
                _repository = RepositoryFactory.GetRepository(Gender.Men);
            }

            InitializeComponent();    
        }
        #endregion

        #region Private Methods
        private void PlayersRankView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private async void GetData()
        {

            _loading.Show(FindForm());

            try
            {
                IList<Match> matches = await _repository.GetTeamMatchesData();
                IList<Match> favoritTeamMatchs = matches.Where(x => x.HomeTeamCountry.Contains(_model.Settings.FavoritTeam) || x.AwayTeamCountry.Contains(_model.Settings.FavoritTeam)).ToList();
                if (favoritTeamMatchs.Count > 0)
                {
                    _model.Players = favoritTeamMatchs[0].HomeTeamStatistics.StartingEleven.Union(favoritTeamMatchs[0].HomeTeamStatistics.Substitutes).ToList();

                }

                foreach (var favoritTeamMatch in favoritTeamMatchs)
                {
                    foreach (var player in _model.Players)
                    {
                        IList<TeamEvent> goalTeamEvent = favoritTeamMatch.HomeTeamEvents.Where(x => x.Player.Contains(player.Name) && x.TypeOfEvent.Equals(TypeOfEvent.Goal)).ToList();
                        IList<TeamEvent> yellowCardTeamEvent = favoritTeamMatch.HomeTeamEvents.Where(x => x.Player.Contains(player.Name) && x.TypeOfEvent.Equals(TypeOfEvent.YellowCard)).ToList();
                        
                        if (goalTeamEvent.Count == 1)
                        {
                            player.Goals += 1;
                        }

                        if (yellowCardTeamEvent.Count == 1)
                        {
                            player.YellowCards += 1;
                        }
                    }
                }

                PerformBinding();
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
            finally
            {
                _loading.Close();
            }
        }

        private void TablePanelDataBinding(TableLayoutPanel tblPanel, TypeOfPlayerSort selectedSort)
        {
            List<Player> players = _model.Players;

            if (players == null)
            {
                return;
            }

            switch (selectedSort)
            {
                case TypeOfPlayerSort.Goal:
                    players.Sort(new PlayerGoalComparer());
                    break;
                case TypeOfPlayerSort.YellowCard:
                    players.Sort(new PlayerYellowCardComparer());
                    break;
                default:
                    break;
            }

            SetupTableLayoutPanel(tblPanel);
            tblPanel.Controls.Clear();
            tblPanel.SuspendLayout();

            try
            {
                foreach (var player in players)
                {
                    PlayerControl playerControl = new PlayerControl { Player = player };
                    if (selectedSort == TypeOfPlayerSort.Goal)
                    {
                        SetPlayerGoalIcon(playerControl, true);
                    } 
                    else if (selectedSort == TypeOfPlayerSort.YellowCard)
                    {
                        SetPlayerYellowCardIcon(playerControl, true);
                    }

                    tblPanel.Controls.Add(playerControl);
                }
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }

            tblPanel.ResumeLayout();
        }
        private void ComboBoxDataBindings(ComboBox control, IEnumerable<object> objects, int? selected)
        {
            control.DataSource = objects.ToList();
            control.DisplayMember = "Name";
            control.ValueMember = "Id";
            if (selected != null) control.SelectedIndex = (int)selected;
        }

        private void SetupTableLayoutPanel(TableLayoutPanel tblPanel)
        {
            tblPanel.ColumnCount = 1;
            tblPanel.RowCount = 0;

            tblPanel.AutoScroll = true;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tblPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }

        private void SetPlayerGoalIcon(PlayerControl playerControl, bool goals)
        {
            playerControl.Goals = goals;
            playerControl.SetGoalsStaus();
        }

        private void SetPlayerYellowCardIcon(PlayerControl playerControl, bool yellowCards)
        {
            playerControl.YellowCards = yellowCards;
            playerControl.SetYellowCardsStatus();
        }
        #endregion

        public override void PerformBinding()
        {
            ComboBoxDataBindings(cbSort, _model.TypeOfPlayerSort, null);
            TablePanelDataBinding(tblPanelRankPlayers, TypeOfPlayerSort.Goal);
            cbSort.SelectedValueChanged += new EventHandler(CbSort_SelectedValueChanged);
        }

        private void CbSort_SelectedValueChanged(object sender, EventArgs e)
        {
            _loading.Show(FindForm());

            try
            {
                ComboBox comboBox = sender as ComboBox;
                TypeOfPlayerSort selectedSort = (TypeOfPlayerSort)comboBox.SelectedIndex;
                TablePanelDataBinding(tblPanelRankPlayers, selectedSort);
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
            finally
            {
                _loading.Close();
            }
        }
    }
}
