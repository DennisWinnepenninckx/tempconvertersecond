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

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            double userIput = Double.Parse(textBoxFahrenheit.Text);
            double celsius = (userIput - 32) / 1.8;
            textBoxCelsius.Text = celsius.ToString();

        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            double userIput = Double.Parse(textBoxCelsius.Text);
            double celsius = userIput * 1.8 +32;
            textBoxFahrenheit.Text = celsius.ToString();
        }
    }
}
