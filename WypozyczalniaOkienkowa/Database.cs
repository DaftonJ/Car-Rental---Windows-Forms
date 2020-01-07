using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaOkienkowa
{
    public static class Database
    {
        public static List<Client> Clients = new List<Client>();
        public static List<Contract> Contracts = new List<Contract>();
        public static List<RentalOffice> RentalOffices;

        public static void Load()// ŁADOWAŚNKO XDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

        { 
            string Query = @"SELECT * FROM Cars";
            using (SqlConnection con = new SqlConnection("Data Source=89.70.250.24;Initial Catalog=CarRental;Persist Security Info=True;User ID=JiPP2019;Password=ZaliczenieSemestru2"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(Query, con))
                {

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Car car = new Car
                        {
                            Brand = reader["Brand"].ToString(),
                            Model = reader["Model"].ToString(),
                            Price = decimal.Parse(reader["Price"].ToString()),
                        };
                       
                       RentalOffices.SingleOrDefault(x => x.Name == reader["RentalOffice"].ToString()).Cars.Add(car);
                        
                        
                    }

                }

            }

        }
        public static void Init()
        {
            Client c = new Client("Filip","Osiński",21,99999999);
            c.Register("dawidek","a");
            Clients.Add(c);
       

            RentalOffices = new List<RentalOffice>()
            {
                new RentalOffice("U Januszka"),
                new RentalOffice("SebAutos"),
            };
            Load();
        }

    }
}
