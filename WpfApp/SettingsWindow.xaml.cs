using DAL.DataTypes.Enums;
using DAL.Models;
using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        private readonly SettingsViewModel _model;

        public SettingsWindow(SettingsViewModel model = null)
        {
            if (model != null)
            {
                _model = model;
            } else
            {
                _model = new SettingsViewModel();
            }
            
            InitializeComponent();
            SetupComboBoxes();
        }


        private void SetupComboBoxes()
        {
            cmbLanguages.ItemsSource = _model.Languages.ToList();
            cmbLanguages.DisplayMemberPath = "Name";

            cmbGenders.ItemsSource = _model.Genders.ToList();
            cmbGenders.DisplayMemberPath = "Name";

            cmbResolutions.ItemsSource = _model.Resolutions.ToList();
            cmbResolutions.DisplayMemberPath = "Name";
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            _model.SelectedLang = (Lang)cmbLanguages.SelectedIndex;
            _model.SelectedGender = (Gender)cmbGenders.SelectedIndex;
            _model.SelectedResolution = (Resolution)cmbResolutions.SelectedIndex;

            Setting settings = new Setting
            {
                Lang = _model.SelectedLang,
                Gender = _model.SelectedGender,
                Resolution = _model.SelectedResolution,
                FavoritTeam = _model.SelectedTeam
            };

            FileService.CreateFile(settings);

            DialogResult = true;
            Close();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
        
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSave.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
            else if (e.Key == Key.Escape)
            {
                btnExit.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cmbLanguages.SelectedIndex = (int)_model.SelectedLang;
            cmbGenders.SelectedIndex = (int)_model.SelectedGender;
            cmbResolutions.SelectedIndex = (int)_model.SelectedResolution;
        }
    }
}
