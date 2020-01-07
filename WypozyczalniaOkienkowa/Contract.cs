using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaOkienkowa
{
    public class Contract
    {
        public Client Client;
        public Car RentedCar;
        public RentalOffice Office;

        public Contract()
        {
                
        }

        public Contract(Client client, Car rentedCar, RentalOffice office)
        {
            Client = client;
            RentedCar = rentedCar;
            Office = office;
        }
        public void Print()
        {
            string content = $"Umowa zawarta między {Client.Name} {Client.Surname} a {Office.Name} na pojazd {RentedCar.Brand} {RentedCar.Model} za kwote {RentedCar.Price}$ za godzine";
            File.AppendAllText($"Umowa {Client.Name} {Client.Surname} - {DateTime.Now.Date.ToShortDateString()} - {DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second}.txt", content);
        }
    }
}
