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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf7
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

        private void helloButton_Click(object sender, RoutedEventArgs e)
        {
            //DoubleAnimation buttonAnimation = new DoubleAnimation();
            //buttonAnimation.From = helloButton.ActualWidth;
            //buttonAnimation.To = 150;
            //buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            //buttonAnimation.AutoReverse = true;
            //buttonAnimation.RepeatBehavior = RepeatBehavior.Forever;

            //// анимация для высоты
            //DoubleAnimation heightAnimation = new DoubleAnimation();
            //heightAnimation.From = helloButton.ActualHeight;
            //heightAnimation.To = 60;
            //heightAnimation.Duration = TimeSpan.FromSeconds(5);

            //helloButton.BeginAnimation(Button.WidthProperty, buttonAnimation);
            //helloButton.BeginAnimation(Button.HeightProperty, heightAnimation);
        }
    }
}
