using DAL;
using DAL.DataTypes.Enums;
using DAL.Extensions;
using DAL.Models;
using DAL.Properties;
using DAL.Repositories;
using DAL.Services;
using Loader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Events;
using WindowsFormsApp.Models;
using WindowsFormsApp.Views;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        #region Private Fields
        private BaseView _view;
        private BaseViewModel _model;
        private Loading _loading;
        private IRepository _repository;
        #endregion

        #region Private Methods
        private void SwapView(TypeOfView? view = null)
        {
            if (view != null)
            {
                Controls.Remove(_view);

                switch (view)
                {
                    case TypeOfView.MainView:
                        Setting settings = FileService.ReadSettingsFile();
                        Dal(settings.Gender);
                        _model = new MainViewModel(settings);
                        _view = new MainView(_model as MainViewModel, _loading, _repository);
                        break;
                    case TypeOfView.SettingsView:
                        _model = new SettingsViewModel();
                        _view = new SettingsView(_model as SettingsViewModel, _loading, _repository);
                        break;
                    case TypeOfView.FavoritTeamView:
                        _view = new FavoritTeamView(_model as SettingsViewModel, _loading, _repository);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                AlertBox.Show(AlertType.Error);
            }

            Controls.Add(_view);
            SubscribeToEvents();

            
        }

        private void SubscribeToEvents()
        {
            MainView mainView;
            SettingsView settingsView;
            FavoritTeamView favoritTeamView;

            TypeOfView typeOfView = GetTypeOfView();

            switch (typeOfView)
            {
                case TypeOfView.MainView:
                    mainView = (MainView)_view;
                    mainView.SaveSettings += new SettingsDelegate(SaveSettings);
                    break;
                case TypeOfView.SettingsView:
                    settingsView = (SettingsView)_view;
                    settingsView.ViewChange += new ViewDelegate(ChangeView);
                    settingsView.InitDal += new DalDelegate(InitDal);
                    break;
                case TypeOfView.FavoritTeamView:
                    favoritTeamView = (FavoritTeamView)_view;
                    favoritTeamView.ViewChange += new ViewDelegate(ChangeView);
                    favoritTeamView.SaveSettings += new SettingsDelegate(SaveSettings);
                    break;
                default:
                    break;
            }

            
        }

        private TypeOfView GetTypeOfView()
        {
            var currentViewName = _view.GetType().Name;
            TypeOfView typeOfView = (TypeOfView)Enum.Parse(typeof(TypeOfView), currentViewName, true);

            return typeOfView;
        }

        private void Dal(Gender gender)
        {
            try
            {
                _repository = RepositoryFactory.GetRepository(gender);
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
        }

        private void ChangeView(object sender, ViewEventArgs e)
        {
            SwapView(e.ViewName);
        }

        private void InitDal(object sender, DalEventArgs e)
        {
            Dal(e.SelectedGender);
        }

        private void SaveSettings(object sender, SettingsEventArgs e)
        {
            SaveSettingsData(e.Settings);
        }
        #endregion

        #region Public Methods
        public void SaveSettingsData(Setting settings)
        {
            try
            {
                FileService.CreateFile(settings);
            }
            catch (Exception)
            {
                AlertBox.Show(AlertType.Error);
            }
        }

        #endregion

        #region Ctor
        public MainForm()
        {
            if (FileService.FileExist())
            {
                SwapView(TypeOfView.MainView);
            }
            else
            {
                SwapView(TypeOfView.SettingsView);
            }

            _loading = new Loading();
            
            InitializeComponent();
        }
        #endregion

        #region Exit application
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(Messages.ExitMessage.GetDescription(), Messages.ExitTitle.GetDescription(),
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                _loading.Close();
            }
        }
        #endregion
    }
}
