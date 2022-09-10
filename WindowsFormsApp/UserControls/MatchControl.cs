using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.UserControls
{
    public partial class MatchControl : UserControl
    {
        public Match Match { get; set; }

        public MatchControl()
        {
            InitializeComponent();
        }

        private void MatchControl_Load(object sender, EventArgs e)
        {
            SetMatch();
        }

        private void SetMatch()
        {
            lbLocation.Text = Match.Location.ToString();
            lbAttendance.Text = Match.Attendance.ToString();
            lblHomeTeam.Text = Match.HomeTeamCountry;
            lblAwayTeam.Text = Match.AwayTeamCountry;
        }
    }
}
