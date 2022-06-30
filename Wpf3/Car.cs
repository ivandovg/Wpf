using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf3
{
    public class Car
    {
        private static int count = 0;

        public  int Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Color { get; set; }
        public bool State { get; set; }
        public short Year { get; set; }

        public Car()
        {
            Id = ++count;
        }

        public override string ToString()
        {
            return $"{Name}({Year}), {Color}";
        }
    }
}
