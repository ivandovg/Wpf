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
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private ObservableCollection<Product> products;
        public ProductsWindow()
        {
            products = new ObservableCollection<Product>();
            products.Add(new Product() { Name = "P1", Category = "C1", Count = 10, Cost = 15.70 });
            products.Add(new Product() { Name = "P2", Category = "C2", Count = 15, Cost = 215.70 });
            products.Add(new Product() { Name = "P3", Category = "C1", Count = 5, Cost = 125.70 });

            InitializeComponent();

            lstProducts.DisplayMemberPath = "Name";
            lstProducts.ItemsSource = products;
        }
    }
}
