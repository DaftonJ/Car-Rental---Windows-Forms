using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaOkienkowa
{
    public partial class MyRentsPage : UserControl
    {
       
        public MyRentsPage(Client c)
        {
            InitializeComponent();
            foreach (var contract in c.Contracts)
            {
                rentsListBox.Items.Add($"{contract.RentedCar.Brand} {contract.RentedCar.Model}");
            }
        }
    }
}
