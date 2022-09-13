using DAL.DataTypes.Enums;
using DAL.Extensions;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    public sealed class SettingsViewModel : BaseViewModel
    {
        #region Private fields
        private IEnumerable<object> _genders;
        private IEnumerable<object> _languages;
        private IEnumerable<object> _resolutions;
        private Gender _selectedGender;
        private Lang _selectedLang;
        private Resolution _selectedResolution;
        private string _selectedTeam;
        private List<Team> _teams;
        #endregion

        #region Public Properties
        public IEnumerable<object> Genders 
        { 
            get => _genders;
            set
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Genders)));
            } 
        }
        public IEnumerable<object> Languages 
        { 
            get => _languages; 
            set
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Languages)));
            }
        }
        public IEnumerable<object> Resolutions
        {
            get => _resolutions;
            set
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Resolutions)));
            }
        }
        public Gender SelectedGender
        {
            get => _selectedGender;
            set
            {
                _selectedGender = value;
            }
        }
        public Lang SelectedLang
        {
            get => _selectedLang;
            set
            {
                _selectedLang = value;
            }
        }

        public Resolution SelectedResolution
        {
            get => _selectedResolution;
            set
            {
                _selectedResolution = value;
            }
        }
        public string SelectedTeam
        {
            get => _selectedTeam;
            set
            {
                _selectedTeam = value;
            }
        }
        public List<Team> Teams
        {
            get => _teams;
            set
            {
                _teams = value;
            }
        }
        #endregion

        #region Ctor
        public SettingsViewModel()
        {
            _genders = from Gender gender in Enum.GetValues(typeof(Gender))
                       select new
                       {
                           Id = (int)gender,
                           Name = gender.GetDescription()
                       };

            _languages = from Lang lang in Enum.GetValues(typeof(Lang))
                         select new
                         {
                             Id = (int)lang,
                             Name = lang.GetDescription()
                         };

            _resolutions = from Resolution resolution in Enum.GetValues(typeof(Resolution))
                         select new
                         {
                             Id = (int)resolution,
                             Name = resolution.GetDescription()
                         };
        }
        #endregion
    }
}
