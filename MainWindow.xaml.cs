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
using WpfApp30.Classes;
using WpfApp30.Pages;


namespace WpfApp30
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainWindowFrame;
            Manager.MainFrame.Navigate(new Menu());
        }
        private void BtnProducts_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductList());
        }

        private void BtnServices_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new ServicesList());
        }

        private void BtnDealers_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new DealersList());
        }

        private void BtnOut_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
    }
}
