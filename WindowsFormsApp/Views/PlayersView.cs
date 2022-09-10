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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Events;
using WindowsFormsApp.Models;
using WindowsFormsApp.UserControls;

namespace WindowsFormsApp.Views
{
    public sealed partial class PlayersView : BaseView
    {
        #region Private fields
        private readonly PlayersViewModel _model;
        #endregion

        #region Ctor
        public PlayersView(PlayersViewModel model = null, Loading loading = null, IRepository repository = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new PlayersViewModel();
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
        private void PlayersView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private async void GetData()
        {

            _loading.Show(FindForm());

            try
            {
                IList<Match> matches = await _repository.GetTeamMatchesData();
                Match favoritTeamMatch = matches.Where(x => x.HomeTeamCountry.Contains(_model.Settings.FavoritTeam)).FirstOrDefault();

                _model.Players = favoritTeamMatch.HomeTeamStatistics.StartingEleven.Union(favoritTeamMatch.HomeTeamStatistics.Substitutes).ToList();
                _model.Players.Sort();

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
        private void TablePanelDataBinding(TableLayoutPanel tblPanel, bool favoritePlayers)
        {
            IList<Player> players = favoritePlayers ? _model.Settings.FavoritPlayers : _model.Players;

            if (players == null)
            {
                return;
            }

            SetupTableLayoutPanel(tblPanel);
            tblPanel.Controls.Clear();
            tblPanel.SuspendLayout();

            try
            {
                foreach (var player in players)
                {
                    PlayerControl playerControl = new PlayerControl { Player = player, Favorite = false };
                    
                    if (favoritePlayers)
                    {
                        SetPlayerFavoriteIcon(playerControl, true);
                        playerControl.ContextMenuStrip = cmRemovePlayerFromFavorite;
                    } else
                    {
                        SetPlayerFavoriteIcon(playerControl, false);
                        playerControl.ContextMenuStrip = cmAddPlayerToFavorite;
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

        private void SetupTableLayoutPanel(TableLayoutPanel tblPanel)
        {
            tblPanel.ColumnCount = 1;
            tblPanel.RowCount = 0;

            tblPanel.AutoScroll = true;
            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;
            tblPanel.Padding = new Padding(0, 0, vertScrollWidth, 0);
        }
        private void AddToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerControl playerControl = (PlayerControl)cmAddPlayerToFavorite.SourceControl;
            
            if (!CheckMaxFavoritePlayers() && playerControl != null)
            {
                MovePlayerControlToFavorites(playerControl);
            }
        }

        private void RemoveFromFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerControl playerControl = (PlayerControl)cmRemovePlayerFromFavorite.SourceControl;
            if (playerControl != null)
            {
                RemovePlayerControlFromFavorites(playerControl);
            }
           
        }

        private void MovePlayerControlToFavorites(PlayerControl playerControl)
        {
            SetPlayerFavoriteIcon(playerControl, true);
            playerControl.ContextMenuStrip = cmRemovePlayerFromFavorite;
            tblPanelPlayers.Controls.Remove(playerControl);
            tblPanelFavoritPlayers.Controls.Add(playerControl);
        }

        private void RemovePlayerControlFromFavorites(PlayerControl playerControl)
        {
            SetPlayerFavoriteIcon(playerControl, false);
            playerControl.ContextMenuStrip = cmAddPlayerToFavorite;
            tblPanelFavoritPlayers.Controls.Remove(playerControl);
            tblPanelPlayers.Controls.Add(playerControl);
        }

        private void SetPlayerFavoriteIcon(PlayerControl playerControl, bool favorite)
        {
            playerControl.Favorite = favorite;
            playerControl.SetFavoritePlayerStatus();
        }

        private bool CheckMaxFavoritePlayers()
        {
            return tblPanelFavoritPlayers.Controls.Count >= 3;
        }
        #endregion

        public override void PerformBinding()
        {
            TablePanelDataBinding(tblPanelPlayers, false);
            TablePanelDataBinding(tblPanelFavoritPlayers, true);
        }

        public void SaveFavoritePlayers(SettingsDelegate saveSettings)
        {
            TableLayoutControlCollection favoritePlayerControls = tblPanelFavoritPlayers.Controls;

            IList<Player> favoritePlayers = new List<Player>();

            foreach (var favoritePlayerControl in favoritePlayerControls)
            {
                PlayerControl player = (PlayerControl)favoritePlayerControl;
                favoritePlayers.Add(player.Player);
            }

            _model.Settings.FavoritPlayers = favoritePlayers;
            saveSettings?.Invoke(this, new SettingsEventArgs { Settings = _model.Settings });
        }
    }
}
