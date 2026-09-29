using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ImageBrush img = new ImageBrush();
            StreamReader sr = File.OpenText("in.txt");
            string s = "";
            int NumFirst = 0;
            int NumSecond = 0;
            int i = 0;
            bool iffirst = true;
            while ((s = sr.ReadLine()) != null)
            {
                iffirst = true;
                if (s.Length == 8 || s.Length == 9)
                {
                    if (s[0] == '0' && s[1] == '0' && s[2] == '0' && s[3] == '0')
                    {
                        iffirst = false;
                        NumFirst = s[5] - '0';
                        NumSecond = s[7] - '0';
                        if (s.Length == 9)
                        {
                            NumSecond *= 10;
                            NumSecond += s[8] - '0';
                        }
                    }
                }
                if (iffirst)
                {
                    string nameofprop = i.ToString();
                    App.Current.Properties[nameofprop + "a"] = s;
                    App.Current.Properties[nameofprop + "b"] = NumFirst;
                    App.Current.Properties[nameofprop + "c"] = NumSecond;
                    i++;
                }
            }
            App.Current.Properties["Result"] = 0;
            App.Current.Properties["Max"] = i;
            App.Current.Properties["HMTime"] = 0;
            App.Current.Properties["MaxLevelNumber"] = 10;
            frame.NavigationService.Navigate(new WelcomePage());
        }
    }
}
