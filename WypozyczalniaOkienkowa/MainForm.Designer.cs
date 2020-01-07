namespace WypozyczalniaOkienkowa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rentalOfficeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.myRentsButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pagePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.rentalOfficeButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.myRentsButton);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.moneyLabel);
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 0;
            // 
            // rentalOfficeButton
            // 
            this.rentalOfficeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.rentalOfficeButton.Location = new System.Drawing.Point(159, 0);
            this.rentalOfficeButton.Name = "rentalOfficeButton";
            this.rentalOfficeButton.Size = new System.Drawing.Size(135, 37);
            this.rentalOfficeButton.TabIndex = 5;
            this.rentalOfficeButton.Text = "Wypożyczalnia";
            this.rentalOfficeButton.UseVisualStyleBackColor = true;
            this.rentalOfficeButton.Click += new System.EventHandler(this.RentalOfficeButton_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(135, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 37);
            this.panel2.TabIndex = 4;
            // 
            // myRentsButton
            // 
            this.myRentsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.myRentsButton.Location = new System.Drawing.Point(0, 0);
            this.myRentsButton.Name = "myRentsButton";
            this.myRentsButton.Size = new System.Drawing.Size(135, 37);
            this.myRentsButton.TabIndex = 3;
            this.myRentsButton.Text = "Moje wypożyczenia";
            this.myRentsButton.UseVisualStyleBackColor = true;
            this.myRentsButton.Click += new System.EventHandler(this.MyRentsButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.nameLabel.ForeColor = System.Drawing.Color.Blue;
            this.nameLabel.Location = new System.Drawing.Point(545, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 37);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Imie nazwisko";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.moneyLabel.ForeColor = System.Drawing.Color.Green;
            this.moneyLabel.Location = new System.Drawing.Point(645, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(74, 37);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "99999$";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoutButton
            // 
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.logoutButton.Location = new System.Drawing.Point(719, 0);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(81, 37);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pagePanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 413);
            this.panel3.TabIndex = 1;
            // 
            // pagePanel
            // 
            this.pagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePanel.Location = new System.Drawing.Point(0, 0);
            this.pagePanel.Name = "pagePanel";
            this.pagePanel.Size = new System.Drawing.Size(800, 413);
            this.pagePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Panel użytkownika";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button rentalOfficeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button myRentsButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pagePanel;
    }
}