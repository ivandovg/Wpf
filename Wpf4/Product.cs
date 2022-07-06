using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Wpf4
{
    public class Product:INotifyPropertyChanged
    {
        private string name;
        private string category;
        private int count;
        private double cost;

        public string Name {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException();

                SetChanged(ref name, value, nameof(Name));
            }
        }

        public string Category
        {
            get => category;
            set
            {
                SetChanged(ref category, value, nameof(Category));
            }
        }
        public int Count
        {
            get => count;
            set
            {
                SetChanged(ref count, value, nameof(Count));
            }
        }
        public double Cost
        {
            get => cost;
            set
            {
                SetChanged(ref cost, value, nameof(Cost));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void SetChanged<T>(ref T field, T value, string propertyName)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
