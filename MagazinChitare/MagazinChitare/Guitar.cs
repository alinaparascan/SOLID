using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinChitare
{
    public class Guitar
    {
        public string SerialNumber{ get; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; }

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.SerialNumber = serialNumber;
            this.Price = price;
            this.Spec = spec;
        }
    }
}
