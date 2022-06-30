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
using System.Windows.Shapes;

namespace Wpf1
{
    /// <summary>
    /// Логика взаимодействия для GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private int number;
        private int count;
        public GameWindow()
        {
            number = new Random().Next(1, 20);
            count = 5;
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (!int.TryParse(edNumber.Text, out n))
                return;

            count--;
            if (n == number)
            {
                lstResult.Items.Add($"You winn at {count}");
                System.Windows.Forms.MessageBox.Show($"You winn at {count}", "Game over...", System.Windows.Forms.MessageBoxButtons.OK);
                Close();
                return;
            }
            else
            {
                lstResult.Items.Add($"You don't guess, try {count}");
            }

            if (count <= 0)
            {
                System.Windows.Forms.MessageBox.Show($"You loose at {count}", "Game over...", System.Windows.Forms.MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
