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
    public partial class RentalOfficesPage : UserControl
    {
        
        public delegate void PanelClick(Pages page);
        public event PanelClick OnPanelClicked;
        public RentalOfficesPage()
        {
            InitializeComponent();
        }

        private void JanuszPanel_Click(object sender, EventArgs e)
        {
            OnPanelClicked?.Invoke(Pages.Janusz);
        }

        private void SebaPanel_Click(object sender, EventArgs e)
        {
            OnPanelClicked?.Invoke(Pages.Sebautos);
        }


    }
}
