using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WypozyczalniaOkienkowa
{
    public partial class RentalOfficePage : UserControl
    {
        private RentalOffice RentalOffice;
        private Client Client;
        public RentalOfficePage(RentalOffice ro, Client client)
        {
            InitializeComponent();
            RentalOffice = ro;
            Client = client;
            foreach (var car in ro.Cars)
            {
                CarsList.Items.Add(car.Brand + " " + car.Model + " Cena: "+car.Price + "$");
            }
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            int selectedCarIndex = CarsList.SelectedIndex;
            Car car = RentalOffice.Cars[selectedCarIndex];
            if(Client.Money>= car.Price)
            {
                Contract contract = new Contract(Client,car,RentalOffice);
                Thread t = new Thread(()=> contract.Print()); 
                t.Start();
                Client.Money -= car.Price;
                Client.Contracts.Add(contract);
            }
        }
    }
}
