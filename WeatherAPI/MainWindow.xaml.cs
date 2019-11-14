using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace WeatherAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string urlLondon = "https://api.openweathermap.org/data/2.5/forecast?q=London,us&mode=xml&appid=cad1576e51754b57f8b8c5297aa70caa";
        public MainWindow()
        {
            InitializeComponent();

        }

        private void RefreshButton(object sender, RoutedEventArgs e)
        {
            dataGrid1.Items.Refresh();
        }

        private void SearchButton(object sender, RoutedEventArgs e)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadString(urlLondon);
        }
    }
}
