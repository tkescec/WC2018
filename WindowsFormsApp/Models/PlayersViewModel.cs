using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public sealed class PlayersViewModel : BaseViewModel
    {
        #region Private fields
        private List<Player> _players;
        private Setting _settings;
        #endregion

        #region Public Properties
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
        public PlayersViewModel()
        {

        }
        public PlayersViewModel(Setting settings)
        {
            Settings = settings;
        }
        #endregion
    }
}
