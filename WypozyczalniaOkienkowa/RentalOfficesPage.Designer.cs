namespace WypozyczalniaOkienkowa
{
    partial class RentalOfficesPage
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.januszPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sebaPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.januszPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sebaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // januszPanel
            // 
            this.januszPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.januszPanel.Controls.Add(this.pictureBox1);
            this.januszPanel.Controls.Add(this.label1);
            this.januszPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.januszPanel.Location = new System.Drawing.Point(0, 0);
            this.januszPanel.Name = "januszPanel";
            this.januszPanel.Size = new System.Drawing.Size(399, 413);
            this.januszPanel.TabIndex = 0;
            this.januszPanel.Click += new System.EventHandler(this.JanuszPanel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::WypozyczalniaOkienkowa.Properties.Resources.icons8_English_Mustache_104px;
            this.pictureBox1.Location = new System.Drawing.Point(149, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Sawarabi Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "U Januszka";
            // 
            // sebaPanel
            // 
            this.sebaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sebaPanel.Controls.Add(this.pictureBox2);
            this.sebaPanel.Controls.Add(this.label2);
            this.sebaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sebaPanel.Location = new System.Drawing.Point(401, 0);
            this.sebaPanel.Name = "sebaPanel";
            this.sebaPanel.Size = new System.Drawing.Size(399, 413);
            this.sebaPanel.TabIndex = 1;
            this.sebaPanel.Click += new System.EventHandler(this.SebaPanel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::WypozyczalniaOkienkowa.Properties.Resources.icons8_Car_104px;
            this.pictureBox2.Location = new System.Drawing.Point(155, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Sawarabi Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(150, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "SebAutos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(399, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 413);
            this.panel3.TabIndex = 2;
            // 
            // RentalOfficesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sebaPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.januszPanel);
            this.Name = "RentalOfficesPage";
            this.Size = new System.Drawing.Size(800, 413);
            this.januszPanel.ResumeLayout(false);
            this.januszPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sebaPanel.ResumeLayout(false);
            this.sebaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel januszPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sebaPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
    }
}
