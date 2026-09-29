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
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void StartClick(object sender, RoutedEventArgs e)
        {
            App.Current.Properties["StartTime"] = DateTime.Now.ToString();
            App.Current.Properties["LevelNumber"] = 1;
            App.Current.Properties["Result"] = 0;
            this.NavigationService.Navigate(new GameScreen());
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ExitPage());
        }
        
    }
}
