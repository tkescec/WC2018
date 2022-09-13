using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Model
{
    public sealed class TeamDetailsViewModel : BaseViewModel
    {
        #region Private fields
        private Team _teamResult;
        #endregion

        #region Public Properties
        public Team TeamResults
        {
            get => _teamResult;
            set
            {
                _teamResult = value;
            }
        }
        #endregion

        #region Ctor
        public TeamDetailsViewModel()
        {

        }
        #endregion
    }
}
