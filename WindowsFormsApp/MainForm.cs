using DAL.DataTypes.Enums;
using DAL.Extensions;
using DAL.Properties;
using DAL.Services;
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
                        _view = new MainView(_model as MainViewModel);
                        break;
                    case TypeOfView.SettingsView:
                        _view = new SettingsView(_model as SettingsViewModel);
                        SubscribeToEvent(_view);
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
        }

        private void SubscribeToEvent(BaseView view)
        {
            SettingsView settingsView = (SettingsView)view;
            settingsView.LangChange += new CultureDelegate(ChangeLang);
        }

        private void ChangeLang(object sender, CultureEventArgs e)
        {
            SetCulture(e.CultureName);
        }
        #endregion

        #region Public Methods
        public void SetCulture(string cultureName)
        {
            try
            {
                CultureInfo customCulture = new CultureInfo(cultureName);
                Thread.CurrentThread.CurrentUICulture = customCulture;
                Thread.CurrentThread.CurrentCulture = customCulture;
                EnumResources.Culture = customCulture;

                var currentViewName = _view.GetType().Name;
                TypeOfView typeOfView = (TypeOfView)Enum.Parse(typeof(TypeOfView), currentViewName, true);

                SwapView(typeOfView);
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
                _model = new MainViewModel();
                SwapView(TypeOfView.MainView);
            }
            else
            {
                _model = new SettingsViewModel();
                SwapView(TypeOfView.SettingsView);
            }

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
                //_waitDialog.Close();
            }
        }
        #endregion
    }
}
