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
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : Page
    {
        public ResultsPage()
        {
            InitializeComponent();
            DateTime MyStart = DateTime.Parse(App.Current.Properties["StartTime"].ToString());
            TimeSpan HowManyTime = DateTime.Now - MyStart;
            string result = App.Current.Properties["Result"].ToString();
            string maxscore = App.Current.Properties["MaxLevelNumber"].ToString();
            ResultScore.Text = result + '/' + maxscore;
            if (int.Parse(result) < int.Parse(maxscore))
            {
                ResultScore.Foreground = Brushes.Red;
                ResultTime.Foreground = Brushes.Red;
            }
            else
            {
                ResultScore.Foreground = Brushes.Green;
                ResultTime.Foreground = Brushes.Green;
            }
            ResultTime.Text = HowManyTime.ToString("hh") + ":" + HowManyTime.ToString("mm") + ":" + HowManyTime.ToString("ss") + "." + HowManyTime.ToString("fff");
        }

        private void AgainClick(object sender, RoutedEventArgs e)
        {
            App.Current.Properties["StartTime"] = DateTime.Now.ToString();
            App.Current.Properties["LevelNumber"] = 1;
            App.Current.Properties["Result"] = 0;
            this.NavigationService.Navigate(new GameScreen());
        }

        private void LeaveClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new WelcomePage());
        }
    }
}
