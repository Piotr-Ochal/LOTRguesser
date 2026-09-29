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
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;

namespace ProjectLOTR
{
    /// <summary>
    /// Interaction logic for GameScreen.xaml
    /// </summary>
    public partial class GameScreen : Page
    {
        public Button lastFirst;
        public Button lastSecond;
        public DateTime MyStart = DateTime.Parse(App.Current.Properties["StartTime"].ToString());
        public int max = int.Parse(App.Current.Properties["Max"].ToString());
        public int levelnumber = int.Parse(App.Current.Properties["LevelNumber"].ToString());
        public int maxlevelnumber = int.Parse(App.Current.Properties["MaxLevelNumber"].ToString());
        public int UserAns1 = 16;
        public int UserAns2 = 16;
        public GameScreen()
        {
            InitializeComponent();
            DispatcherTimer clock = new DispatcherTimer();
            clock.Tick += new EventHandler(whenTimer);
            clock.Interval = TimeSpan.FromMilliseconds(1);
            clock.Start();

            var rnd = new Random();
            int ile = rnd.Next(0, max - 2);
            string ileString = ile.ToString();
            App.Current.Properties["PartOfText"] = ileString;
            Tekst.Text = App.Current.Properties[ile.ToString() + 'a'].ToString() +
                   ' ' + App.Current.Properties[(ile + 1).ToString() + 'a'].ToString();
            LevelNumber.Text = levelnumber.ToString() + '/' + maxlevelnumber.ToString();
        }
        public void whenTimer(object sender, EventArgs e)
        {
            TimeSpan HowManyTime = DateTime.Now - MyStart;
            Time.Text = HowManyTime.ToString("hh") + ":" + HowManyTime.ToString("mm") + ":" + HowManyTime.ToString("ss") + "." + HowManyTime.ToString("fff");
        }

        private void NextClick(object sender, RoutedEventArgs e)
        {
            string Part = App.Current.Properties["PartOfText"].ToString();
            int Ans1 = Int32.Parse(App.Current.Properties[Part + "b"].ToString());
            int Ans2 = Int32.Parse(App.Current.Properties[Part + "c"].ToString());
            if (Ans1 == UserAns1 && Ans2 == UserAns2)
            {
                App.Current.Properties["Result"] = Int32.Parse(App.Current.Properties["Result"].ToString()) + 1;
            }
            if (levelnumber == maxlevelnumber)
            {
                this.NavigationService.Navigate(new ResultsPage());
            }
            else
            {
                App.Current.Properties["LevelNumber"] = levelnumber + 1;
                this.NavigationService.Navigate(new GameScreen());
            }
        }
        private void PauseClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PauseMenu());
        }




        private void ClickFirst0(object sender, RoutedEventArgs e)
        {
            UserAns1 = 0;
            First0.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First0;
        }
        private void ClickFirst1(object sender, RoutedEventArgs e)
        {
            UserAns1 = 1;
            First1.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First1;
        }
        private void ClickFirst2(object sender, RoutedEventArgs e)
        {
            UserAns1 = 2;
            First2.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First2;
        }
        private void ClickFirst3(object sender, RoutedEventArgs e)
        {
            UserAns1 = 3;
            First3.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First3;
        }
        private void ClickFirst4(object sender, RoutedEventArgs e)
        {
            UserAns1 = 4;
            First4.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First4;
        }
        private void ClickFirst5(object sender, RoutedEventArgs e)
        {
            UserAns1 = 5;
            First5.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First5;
        }
        private void ClickFirst6(object sender, RoutedEventArgs e)
        {
            UserAns1 = 6;
            First6.IsEnabled = false;
            if (lastFirst != null) lastFirst.IsEnabled = true;
            lastFirst = First6;
        }
        private void ClickSecond1(object sender, RoutedEventArgs e)
        {
            UserAns2 = 1;
            Second1.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second1;
        }
        private void ClickSecond2(object sender, RoutedEventArgs e)
        {
            UserAns2 = 2;
            Second2.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second2;
        }
        private void ClickSecond3(object sender, RoutedEventArgs e)
        {
            UserAns2 = 3;
            Second3.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second3;
        }
        private void ClickSecond4(object sender, RoutedEventArgs e)
        {
            UserAns2 = 4;
            Second4.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second4;
        }
        private void ClickSecond5(object sender, RoutedEventArgs e)
        {
            UserAns2 = 5;
            Second5.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second5;
        }
        private void ClickSecond6(object sender, RoutedEventArgs e)
        {
            UserAns2 = 6;
            Second6.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second6;
        }
        private void ClickSecond7(object sender, RoutedEventArgs e)
        {
            UserAns2 = 7;
            Second7.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second7;
        }
        private void ClickSecond8(object sender, RoutedEventArgs e)
        {
            UserAns2 = 8;
            Second8.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second8;
        }
        private void ClickSecond9(object sender, RoutedEventArgs e)
        {
            UserAns2 = 9;
            Second9.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second9;
        }
        private void ClickSecond10(object sender, RoutedEventArgs e)
        {
            UserAns2 = 10;
            Second10.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second10;
        }
        private void ClickSecond11(object sender, RoutedEventArgs e)
        {
            UserAns2 = 11;
            Second11.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second11;
        }
        private void ClickSecond12(object sender, RoutedEventArgs e)
        {
            UserAns2 = 12;
            Second12.IsEnabled = false;
            if (lastSecond != null) lastSecond.IsEnabled = true;
            lastSecond = Second12;
        }
    }
}
