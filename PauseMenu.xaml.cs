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

namespace ProjectLOTR
{
    /// <summary>
    /// Interaction logic for PauseMenu.xaml
    /// </summary>
    public partial class PauseMenu : Page
    {
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void ContinueClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WelcomePage());

        }
    }
}
