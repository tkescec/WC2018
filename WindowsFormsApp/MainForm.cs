using DAL.DataTypes.Enums;
using DAL.Extensions;
using DAL.Services;
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
        private void SetView(TypeOfView? view = null)
        {
            if (view != null)
            {
                Controls.Remove(_view);

                switch (view)
                {
                    case TypeOfView.Main:
                        _model = new MainViewModel();
                        _view = new MainView(_model as MainViewModel);
                        break;
                    case TypeOfView.Settings:
                        _model = new SettingsViewModel();
                        _view = new SettingsView(_model as SettingsViewModel);
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
        #endregion

        #region Ctor
        public MainForm()
        {
            if (FileService.FileExist())
            {
                SetView(TypeOfView.Main);
            } 
            else
            {
                SetView(TypeOfView.Settings);
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
