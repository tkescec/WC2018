using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp.Model;

namespace WpfApp.UserControls
{
    /// <summary>
    /// Interaction logic for PlayerControl.xaml
    /// </summary>
    public partial class PlayerControl : UserControl
    {
        public Player Player { get; set; }
        public PlayerControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            lblShirtNumberData.Content = Player.ShirtNumber;
            tbNameData.Text = Player.Name;
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PlayerDetailsViewModel playerDetailsViewModel = new PlayerDetailsViewModel { Player = Player };
            Window playerDetailsWindow = new PlayerDetailsWindow(playerDetailsViewModel);
            playerDetailsWindow.ShowDialog();
        }
    }
}
