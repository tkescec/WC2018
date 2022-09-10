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
using WindowsFormsApp.Events;
using WindowsFormsApp.Models;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp.Views
{
    public sealed partial class MainView : BaseView
    {
        #region Private fields
        private readonly MainViewModel _model;
        #endregion

        #region Public fields
        public event SettingsDelegate SaveSettings;
        #endregion

        #region Ctor
        public MainView(MainViewModel model = null, Loading loading = null, IRepository repository = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new MainViewModel();
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
        private void MainView_Load(object sender, EventArgs e)
        {
            PerformBinding();
            SetCulture(_model.Settings.Lang, this);
        }

        private void TabMainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            PerformBinding();
        }
        private void TabMainControl_Deselected(object sender, TabControlEventArgs e)
        {
            SaveFavoritPlayers(e.TabPageIndex);
        }

        private void SaveFavoritPlayers(int tabPageIndex)
        {
            ControlCollection controlsInTab = tabMainControl.SelectedTab.Controls;

            if (controlsInTab.Count > 0)
            {
                Control controlInTab = controlsInTab[0];

                if (controlInTab != null && tabPageIndex == 0)
                {
                    PlayersView playerControl = (PlayersView)controlInTab;
                    playerControl.SaveFavoritePlayers(SaveSettings);
                }
            }        
        }
        #endregion

        public sealed override void PerformBinding()
        {
            switch (tabMainControl.SelectedIndex)
            {
                case 0:
                    tabMainControl.SelectedTab.Controls.Clear();
                    tabMainControl.SelectedTab.Controls.Add(new PlayersView(new PlayersViewModel { Players = _model.Players, Settings = _model.Settings }, _loading, _repository));
                    break;
                case 1:
                    tabMainControl.SelectedTab.Controls.Clear();
                    tabMainControl.SelectedTab.Controls.Add(new PlayersRankView(new PlayersRankViewModel { Players = _model.Players, Settings = _model.Settings }, _loading, _repository));
                    break;
                case 2:
                    tabMainControl.SelectedTab.Controls.Clear();
                    tabMainControl.SelectedTab.Controls.Add(new MatchesRankView(new MatchesRankViewModel { Settings = _model.Settings }, _loading, _repository));
                    
                    break;
                default:
                    break;
            }
        }
    }
}
