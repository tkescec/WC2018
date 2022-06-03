using DAL.DataTypes.Enums;
using DAL.Extensions;
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
