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

namespace Wpf2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            //border1.Width = 100;
            border1.Visibility = Visibility.Visible;
        }

        private void btnHide_Click(object sender, RoutedEventArgs e)
        {
            //border1.Width = 0;
            border1.Visibility = Visibility.Collapsed;
        }

        private void btnDockTest_Click(object sender, RoutedEventArgs e)
        {
            new DockWindowTest().ShowDialog();
        }
    }
}
