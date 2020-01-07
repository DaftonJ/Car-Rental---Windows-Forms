namespace WypozyczalniaOkienkowa
{
    partial class MyRentsPage
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
            this.rentsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // rentsListBox
            // 
            this.rentsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rentsListBox.FormattingEnabled = true;
            this.rentsListBox.ItemHeight = 15;
            this.rentsListBox.Location = new System.Drawing.Point(0, 0);
            this.rentsListBox.Name = "rentsListBox";
            this.rentsListBox.Size = new System.Drawing.Size(800, 413);
            this.rentsListBox.TabIndex = 0;
            // 
            // MyRentsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentsListBox);
            this.Name = "MyRentsPage";
            this.Size = new System.Drawing.Size(800, 413);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rentsListBox;
    }
}
