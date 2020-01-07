using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaOkienkowa
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
                
        }

        public Car(string brand, string model,decimal price)
        {
            Brand = brand;
            Model = model;
            Price = price;
        }

    }
}
