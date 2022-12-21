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

namespace wpftest2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page3());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page6());
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page7());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page8());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page9());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page10());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page11());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page12());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page13());
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page14());
        }
    }
}
