using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    internal class Car
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public override string ToString() => $"{Vendor} {Model} {Year}";
    }
}
