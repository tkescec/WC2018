using DAL;
using DAL.DataTypes.Enums;
using DAL.Models;
using DAL.Repositories;
using DAL.Services;
using Loader;
using System;
using System.Windows.Forms;
using WindowsFormsApp.Events;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Views
{
    public sealed partial class FavoritTeamView : BaseView
    {
        #region Private fields
        private readonly SettingsViewModel _model;
        #endregion

        #region Public fields
        public event ViewDelegate ViewChange;
        public event SettingsDelegate SaveSettings;
        #endregion


        #region Ctor
        public FavoritTeamView(SettingsViewModel model = null, Loading loading = null, IRepository repository = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new SettingsViewModel();
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
        private void FavoritTeamView_Load(object sender, EventArgs e)
        {
            SetCulture(_model.SelectedLang, this);
            GetData();
        }

        private async void GetData()
        {
            _loading.Show(FindForm());

            btnSettingsFinish.Enabled = false;
            btnSettingsBack.Enabled = false;

            try
            {
                _model.Teams = await _repository.GetTeamData();
                _model.Teams.Sort();
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

            btnSettingsFinish.Enabled = true;
            btnSettingsBack.Enabled = true;
        }

        private void ListBoxDataBinding(ListBox listBox)
        {
            try
            {
                listBox.DataSource = _model.Teams;
                listBox.DisplayMember = "Name";
                listBox.ValueMember = "Country";
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
        }
        private void SettingsBack_Click(object sender, EventArgs e)
        {
            ViewChange?.Invoke(this, new ViewEventArgs { ViewName = TypeOfView.SettingsView });
        }
        private void SettingsFinish_Click(object sender, EventArgs e)
        {
            SaveSettings?.Invoke(this, new SettingsEventArgs { Settings = new Setting { Lang = _model.SelectedLang, Gender = _model.SelectedGender, FavoritTeam = _model.SelectedTeam } });
            ViewChange?.Invoke(this, new ViewEventArgs { ViewName = TypeOfView.MainView });
        }
        private void SettingsTeam_SelectedValueChanged(object sender, EventArgs e)
        {
            _model.SelectedTeam = lbSettingsTeam.SelectedValue.ToString();
        }
        #endregion

        public sealed override void PerformBinding()
        {
            ListBoxDataBinding(lbSettingsTeam);
        }
    }
}
