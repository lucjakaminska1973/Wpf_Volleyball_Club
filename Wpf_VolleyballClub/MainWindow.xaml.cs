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

using Wpf_VolleyballClub.NewViewModels;
using Wpf_VolleyballClub.View;
namespace Wpf_VolleyballClub
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PlayersViewModel PlayerVM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            PlayerVM = new PlayersViewModel();
          
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnPlayer_Click(object sender, RoutedEventArgs e)
        {
            
            
            
        }
    }
}
