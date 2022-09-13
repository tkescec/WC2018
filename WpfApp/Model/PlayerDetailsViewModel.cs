using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    public sealed class PlayerDetailsViewModel : BaseViewModel
    {
        #region Private fields
        private Player _player;
        #endregion

        #region Public Properties
        public Player Player
        {
            get => _player;
            set
            {
                _player = value;
            }
        }
        #endregion

        #region Ctor
        public PlayerDetailsViewModel()
        {

        }
        #endregion
    }
}
