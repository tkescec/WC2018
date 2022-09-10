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
    public sealed class PlayersRankViewModel : BaseViewModel
    {
        #region Private fields
        private IEnumerable<object> _typeOfPlayerSort;
        private List<Player> _players;
        private Setting _settings;
        #endregion

        #region Public Properties
        public IEnumerable<object> TypeOfPlayerSort
        {
            get => _typeOfPlayerSort;
            set
            {
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(TypeOfPlayerSort)));
            }
        }
        public List<Player> Players
        {
            get => _players;
            set
            {
                _players = value;
            }
        }

        public Setting Settings
        {
            get => _settings;
            set
            {
                _settings = value;
            }
        }
        #endregion

        #region Ctor
        public PlayersRankViewModel()
        {
            _typeOfPlayerSort = from TypeOfPlayerSort typeOfPlayerSort in Enum.GetValues(typeof(TypeOfPlayerSort))
                       select new
                       {
                           Id = (int)typeOfPlayerSort,
                           Name = typeOfPlayerSort.GetDescription()
                       };
        }
        public PlayersRankViewModel(Setting settings) : this()
        {
            Settings = settings;
        }
        #endregion
    }
}
