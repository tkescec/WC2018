using DAL.Models;
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
using System.Windows.Shapes;
using WpfApp.Model;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for TeamDetailsWindow.xaml
    /// </summary>
    public partial class TeamDetailsWindow : Window
    {
        private readonly TeamDetailsViewModel _model;

        public TeamDetailsWindow(TeamDetailsViewModel model = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new TeamDetailsViewModel();
            }

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            lblCountryData.Content = _model.TeamResults.Country;
            lblFIFACodeData.Content = _model.TeamResults.FifaCode;
            lblGamesPlayedData.Content = _model.TeamResults.GamesPlayed;
            lblWinsData.Content = _model.TeamResults.Wins;
            lblLossesData.Content = _model.TeamResults.Losses;
            lblDrawsData.Content = _model.TeamResults.Draws;
            lblGoalsScoredData.Content = _model.TeamResults.GoalsFor;
            lblGoalsReceivedData.Content = _model.TeamResults.GoalsAgainst;
            lblGoalDifferentialData.Content = _model.TeamResults.GoalDifferential;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
