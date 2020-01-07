using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypozyczalniaOkienkowa
{
    public partial class MainForm : Form
    {
        private Client LoggedClient;
        private RentalOfficesPage RentalOfficesPage;
        public MainForm(Client client)
        {
            InitializeComponent();
            LoggedClient = client;
            Init();
            LoggedClient.OnMoneyChanged += () =>
            {
                moneyLabel.Text = LoggedClient.Money.ToString() + "$";
            };
            RentalOfficesPage = new RentalOfficesPage();
            RentalOfficesPage.OnPanelClicked += (page) =>
             {
                 RentalOffice ro=null;
                 switch (page)
                 {
                     case Pages.Janusz:
                         ro = Database.RentalOffices.Single(x => x.Name == "U Januszka");
                         break;
                     case Pages.Sebautos:
                         ro = Database.RentalOffices.Single(x => x.Name == "SebAutos");
                         break;
                     default:
                         break;
                 }
                 ChangePage(new RentalOfficePage(ro,LoggedClient));
             };
        }

        private void Init()
        {
            foreach (var contract in Database.Contracts)
            {
                if (contract.Client == LoggedClient)
                {
                    LoggedClient.Contracts.Add(contract);
                }
            }
            nameLabel.Text = $"{LoggedClient.Name} {LoggedClient.Surname}";
            moneyLabel.Text = LoggedClient.Money+ "$";
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MyRentsButton_Click(object sender, EventArgs e)
        {
            ChangePage(new MyRentsPage(LoggedClient));
        }

        private void RentalOfficeButton_Click(object sender, EventArgs e)
        {
            ChangePage(RentalOfficesPage);
        }
        private void ChangePage(UserControl control)
        {
            pagePanel.Controls.Clear();
            pagePanel.Controls.Add(control);
        }
    }
}
