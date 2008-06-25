namespace PrototypMIS
{
    partial class Foto
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFoto = new System.Windows.Forms.TabPage();
            this.tabPageBeschreibung = new System.Windows.Forms.TabPage();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFoto.SuspendLayout();
            this.tabPageBeschreibung.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFoto);
            this.tabControl1.Controls.Add(this.tabPageBeschreibung);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFoto
            // 
            this.tabPageFoto.Controls.Add(this.pictureBox1);
            this.tabPageFoto.Controls.Add(this.textBoxTitel);
            this.tabPageFoto.Location = new System.Drawing.Point(0, 0);
            this.tabPageFoto.Name = "tabPageFoto";
            this.tabPageFoto.Size = new System.Drawing.Size(240, 245);
            this.tabPageFoto.Text = "Foto";
            // 
            // tabPageBeschreibung
            // 
            this.tabPageBeschreibung.Controls.Add(this.textBoxBeschreibung);
            this.tabPageBeschreibung.Location = new System.Drawing.Point(0, 0);
            this.tabPageBeschreibung.Name = "tabPageBeschreibung";
            this.tabPageBeschreibung.Size = new System.Drawing.Size(240, 245);
            this.tabPageBeschreibung.Text = "Beschreibung";
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(234, 21);
            this.textBoxTitel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 212);
            // 
            // textBoxBeschreibung
            // 
            this.textBoxBeschreibung.Location = new System.Drawing.Point(3, 3);
            this.textBoxBeschreibung.Multiline = true;
            this.textBoxBeschreibung.Name = "textBoxBeschreibung";
            this.textBoxBeschreibung.Size = new System.Drawing.Size(230, 239);
            this.textBoxBeschreibung.TabIndex = 0;
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Foto";
            this.Text = "Foto";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFoto.ResumeLayout(false);
            this.tabPageBeschreibung.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TabPage tabPageBeschreibung;
        private System.Windows.Forms.TextBox textBoxBeschreibung;

    }
}