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
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Uri("/Pages/Home.xaml", UriKind.Relative));

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/Pages/Home.xaml", UriKind.Relative));
        }

        private void Notes_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/Pages/Notes.xaml", UriKind.Relative));
        }

        private void Sounds_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/Pages/Sounds.xaml", UriKind.Relative));
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("/Pages/Payment.xaml", UriKind.Relative));
        }
    }
}
