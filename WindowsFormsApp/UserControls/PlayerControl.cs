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
    public partial class PlayerControl : UserControl
    {
        public Player Player { get; set; }
        public bool Favorite { get; set; }
        public bool Goals { get; set; }
        public bool YellowCards { get; set; }

        public PlayerControl()
        {
            InitializeComponent();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            SetPlayer();
            SetFavoritePlayerStatus();
            SetGoalsStaus();
            SetYellowCardsStatus();
        }

        private void SetPlayer()
        {
            lbPlayerName.Text = Player.Name;
            lbPlayerNumber.Text = Player.ShirtNumber.ToString();
            lbPlayerPosition.Text = Player.Position.ToString();
            lbGoals.Text = Player.Goals.ToString();
            lbYellowCard.Text = Player.YellowCards.ToString();
        }

        public void SetFavoritePlayerStatus()
        {
            switch (Favorite)
            {
                case true:
                    pbFavorit.Visible = true;
                    break;
                case false:
                    pbFavorit.Visible = false;
                    break;
                default:
                    pbFavorit.Visible = false;
                    break;
            }
        }

        public void SetGoalsStaus()
        {
            switch (Goals)
            {
                case true:
                    lbGoals.Visible = true;
                    break;
                case false:
                    lbGoals.Visible = false;
                    break;
                default:
                    lbGoals.Visible = false;
                    break;
            }
        }

        public void SetYellowCardsStatus()
        {
            switch (YellowCards)
            {
                case true:
                    lbYellowCard.Visible = true;
                    break;
                case false:
                    lbYellowCard.Visible = false;
                    break;
                default:
                    lbYellowCard.Visible = false;
                    break;
            }
        }
    }
}
