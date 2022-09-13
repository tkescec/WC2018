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
using System.Windows.Shapes;
using WpfApp.Model;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for PlayerDetailsWindow.xaml
    /// </summary>
    public partial class PlayerDetailsWindow : Window
    {
        private readonly PlayerDetailsViewModel _model;

        public PlayerDetailsWindow(PlayerDetailsViewModel model = null)
        {
            if (model != null)
            {
                _model = model;
            }
            else
            {
                _model = new PlayerDetailsViewModel();
            }

            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetData();
        }

        private void SetData()
        {
            lblNameData.Content = _model.Player.Name;
            lblShirtNumberData.Content = _model.Player.ShirtNumber;
            lblPositionData.Content = _model.Player.Position.ToString();
            switch (_model.Player.Captain)
            {
                case true:
                    lblCaptain.Visibility = Visibility.Visible;
                    break;
                case false:
                    lblCaptain.Visibility = Visibility.Hidden;
                    break;
                default:
                    lblCaptain.Visibility = Visibility.Hidden;
                    break;
            }
            lblGoalsData.Content = _model.Player.Goals;
            lblYellowCardsData.Content = _model.Player.YellowCards;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
