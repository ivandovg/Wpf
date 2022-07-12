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

namespace Wpf4
{
    /// <summary>
    /// Логика взаимодействия для EditProductWindow.xaml
    /// </summary>
    public partial class EditProductWindow : Window
    {
        //private Product product;
        public EditProductWindow(Product product, bool isNewProduct = false)
        {
            //this.product = product;
            DataContext = product;
            InitializeComponent();
            //grid.DataContext = product;
            if (isNewProduct)
                btnCancel.Visibility = Visibility.Visible;

            btnOk.IsEnabled = !string.IsNullOrEmpty(edName.Text);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void edName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (btnOk != null)
                btnOk.IsEnabled = !string.IsNullOrEmpty(edName.Text);
        }
    }
}
