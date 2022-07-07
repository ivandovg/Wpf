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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private ObservableCollection<Product> products;
        private const string fileName = "products.xml";
        public ProductsWindow()
        {
            products = new ObservableCollection<Product>();
            
            if (!LoadData())
            {
                products.Add(new Product() { Name = "P1", Category = "C1", Count = 10, Cost = 15.70 });
                products.Add(new Product() { Name = "P2", Category = "C2", Count = 15, Cost = 215.70 });
                products.Add(new Product() { Name = "P3", Category = "C1", Count = 5, Cost = 125.70 });
            }

            InitializeComponent();

            //lstProducts.DisplayMemberPath = "Name";
            lstProducts.ItemsSource = products;
            //if (products.Count > 0)
            //    lstProducts.SelectedIndex = 0;

            Closing += ProductsWindow_Closing;
        }

        private void ProductsWindow_Closing(object sender, CancelEventArgs e)
        {
            SaveData();
        }
        
        private bool LoadData()
        {
            // load data
            if (!File.Exists(fileName))
                return false;
            // read file 
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Product>), new Type[] { typeof(Product) });
                TextReader reader = new StreamReader(fileName);
                List<Product> pList = x.Deserialize(reader) as List<Product>;
                foreach (Product product in pList)
                {
                    products.Add(product);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void SaveData()
        {
            // save data
            List<Product> pList = new List<Product>(products);
            XmlSerializer x = new XmlSerializer(typeof(List<Product>), new Type[] { typeof(Product) });
            TextWriter writer = new StreamWriter(fileName);
            x.Serialize(writer, pList);
            pList.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product() { Name = "new product" };
            products.Add(p);
            lstProducts.SelectedItem = p;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstProducts.SelectedIndex == -1)
                return;

            if (lstProducts.SelectedItem is Product)
                products.Remove(lstProducts.SelectedItem as Product);
        }
    }
}
