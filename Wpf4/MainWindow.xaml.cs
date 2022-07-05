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

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Binding b = new Binding();
            //b.ElementName = "edName";
            //b.Path = new PropertyPath("Text");

            //Binding b = new Binding("Text");
            //b.ElementName = "edName";

            //var p = new Person();
            //Binding b1 = new Binding("Phone.Number1");
            //b.Source = p;
        }
    }
    public class Phones
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
    }
    public class Person
    {
        public Person()
        {
            Phone = new Phones() { Number1 = 1, Number2 = 2 };
        }
        public string Name { get; set; }
        public double Age { get; set; }
        public Phones Phone { get; set; }
    }

}
