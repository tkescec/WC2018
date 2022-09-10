using DAL.DataTypes.Enums;
using DAL.Extensions;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public sealed class SettingsViewModel : BaseViewModel
    {
        #region Private fields
        private IEnumerable<object> _genders;
        private IEnumerable<object> _languages;
        private Gender _selectedGender;
        private Lang _selectedLang;
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
        }
        #endregion
    }
}
