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
    public partial class LoginForm : Form
    {
      
        public LoginForm()
        {
            InitializeComponent();
            Database.Init();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0)
            {
                var user = Database.Clients.SingleOrDefault(x => x.Login == loginTextBox.Text);
                if (user == null)
                {
                    MessageBox.Show("Użytkownik o podanym loginie nie istnieje", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (user.Password == passwordTextBox.Text)
                    {
                       MainForm mf = new MainForm(user);
                       mf.Show();
                       this.Visible = false;
                        mf.Closing += (ss, ee) => { this.Visible = true; };
                    }
                    else
                    {
                        MessageBox.Show("Logowanie nie powiodło się", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                loginTextBox.Clear();
                passwordTextBox.Clear();


            }
        }
    }
}
