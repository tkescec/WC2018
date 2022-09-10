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
    public sealed partial class MatchesRankView : BaseView
    {
        #region Private fields
        private readonly MatchesRankViewModel _model;
        #endregion

        #region Ctor
        public MatchesRankView(MatchesRankViewModel model = null, Loading loading = null, IRepository repository = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new MatchesRankViewModel();
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
        private void MatchesRankView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private async void GetData()
        {
            _loading.Show(FindForm());

            try
            {
                IList<Match> matches = await _repository.GetTeamMatchesData();
                _model.Matches = matches.Where(x => x.HomeTeamCountry.Contains(_model.Settings.FavoritTeam) || x.AwayTeamCountry.Contains(_model.Settings.FavoritTeam)).ToList();

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
        private void TablePanelDataBinding(TableLayoutPanel tblPanel)
        {
            List<Match> matches = _model.Matches;

            if (matches == null)
            {
                return;
            }

            matches.Sort();

            SetupTableLayoutPanel(tblPanel);
            tblPanel.Controls.Clear();
            tblPanel.SuspendLayout();

            try
            {
                foreach (var match in matches)
                {
                    MatchControl matchControl = new MatchControl { Match = match };
                    
                    tblPanel.Controls.Add(matchControl);
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
        #endregion

        public override void PerformBinding()
        {
            TablePanelDataBinding(tblPanelRankMatches);
        }

        
    }
}
