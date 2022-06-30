using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf3
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        private ObservableCollection<Car> cars;
        public ProductsWindow()
        {
            cars = new ObservableCollection<Car>();
            cars.Add(new Car() { Name = "Mazda", Color = "Red", Year = 2022, Cost = 1000, State = true });
            cars.Add(new Car() { Name = "BMW", Color = "White", Year = 2021, Cost = 1100, State = false });
            cars.Add(new Car() { Name = "Audi", Color = "Blue", Year = 2020, Cost = 1200, State = true });
            cars.Add(new Car() { Name = "Mercedes", Color = "Black", Year = 2022, Cost = 1300, State = false });
            InitializeComponent();
            //foreach (var item in cars)
            //{
            //    lstCars.Items.Add(item);
            //}

            // 2
            //lstCars.Items.Add(new Car() { Name = "Mazda", Color = "Red", Year = 2022, Cost = 1000, State = true });
            //lstCars.Items.Add(new Car() { Name = "BMW", Color = "White", Year = 2021, Cost = 1100, State = false });
            //lstCars.Items.Add(new Car() { Name = "Audi", Color = "Blue", Year = 2020, Cost = 1200, State = true });
            //lstCars.Items.Add(new Car() { Name = "Mercedes", Color = "Black", Year = 2022, Cost = 1300, State = false });

            // 3
            lstCars.ItemsSource = cars;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edName.Text)
                || string.IsNullOrWhiteSpace(edColor.Text)
                || string.IsNullOrWhiteSpace(edCost.Text)
                || string.IsNullOrWhiteSpace(edYear.Text))

                return;

            short year = 0;
            double cost = 0;

            if (!double.TryParse(edCost.Text, out cost) || !short.TryParse(edYear.Text, out year))
                return;

            Car car = new Car()
            {
                Name = edName.Text,
                Color = edColor.Text,
                Cost = cost,
                Year = year,
                State = edState.IsChecked == true
            };

            cars.Add(car);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (lstCars.SelectedItem == null)
                return;

            Car car = (Car)lstCars.SelectedItem;
            cars.Remove(car);
        }

        private void lstCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCars.SelectedItem == null)
                return;

            Car car = (Car)lstCars.SelectedItem;

            edId.Text = car.Id.ToString();
            edName.Text = car.Name;
            edColor.Text = car.Color;
            edCost.Text = car.Cost.ToString();
            edYear.Text = car.Year.ToString();
            edState.IsChecked = car.State;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (lstCars.SelectedItem == null)
                return;

            if (string.IsNullOrWhiteSpace(edName.Text)
                || string.IsNullOrWhiteSpace(edColor.Text)
                || string.IsNullOrWhiteSpace(edCost.Text)
                || string.IsNullOrWhiteSpace(edYear.Text))

                return;

            short year = 0;
            double cost = 0;

            if (!double.TryParse(edCost.Text, out cost) || !short.TryParse(edYear.Text, out year))
                return;


            Car car = (Car)lstCars.SelectedItem;

            lstCars.ItemsSource = null;

            car.Name = edName.Text;
            car.Color = edColor.Text;
            car.Cost = cost;
            car.Year = year;
            car.State = edState.IsChecked == true;

            lstCars.ItemsSource = cars;
        }
    }
}
