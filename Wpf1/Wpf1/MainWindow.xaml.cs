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

namespace Wpf1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool current;
        public MainWindow()
        {
            current = false;
            InitializeComponent();
            //btn1_Click(null, null);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var b = (Button)sender;
                if (current)
                    b.Content = "X";
                else
                    b.Content = "O";

                b.IsEnabled = false;
                current = !current;
            }
        }

        private void btnAboutClick(object sender, RoutedEventArgs e)
        {
            // show about dialog
            AboutWindow1 about = new AboutWindow1();
            about.ShowDialog();
        }

        private void btnGame_Click(object sender, RoutedEventArgs e)
        {
            GameWindow game = new GameWindow();
            game.ShowDialog();
        }
    }
}
