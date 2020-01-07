using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaOkienkowa
{
    public class RentalOffice
    {

        public string Name { get; set; }
        public List<Car> Cars = new List<Car>();


        public RentalOffice(string name)
        {
            Name = name;
        }


    }
}
