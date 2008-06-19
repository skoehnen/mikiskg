namespace PrototypMIS
{
    partial class Notizen
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
            this.menuItemZurueck = new System.Windows.Forms.MenuItem();
            this.menuItemMenu = new System.Windows.Forms.MenuItem();
            this.menuItemCreateNote = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            this.mainMenu1.MenuItems.Add(this.menuItemMenu);
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZurueck_Click);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItemCreateNote);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemCreateNote
            // 
            this.menuItemCreateNote.Text = "Notiz anlegen";
            this.menuItemCreateNote.Click += new System.EventHandler(this.menuItemCreateNote_Click);
            // 
            // Notizen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Menu = this.mainMenu1;
            this.Name = "Notizen";
            this.Text = "Notizen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemCreateNote;
    }
}