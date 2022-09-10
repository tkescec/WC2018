using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Models
{
    public sealed class MatchesRankViewModel : BaseViewModel
    {
        #region Private fields
        private List<Match> _matches;
        private Setting _settings;
        #endregion

        #region Public Properties
        public List<Match> Matches
        {
            get => _matches;
            set
            {
                _matches = value;
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
        public MatchesRankViewModel()
        {

        }
        public MatchesRankViewModel(Setting settings) : this()
        {
            Settings = settings;
        }
        #endregion
    }
}
