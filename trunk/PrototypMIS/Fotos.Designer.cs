namespace PrototypMIS
{
    partial class Fotos
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
            this.menuItemFoto = new System.Windows.Forms.MenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemShow = new System.Windows.Forms.MenuItem();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            this.mainMenu1.MenuItems.Add(this.menuItemFoto);
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZueruck_Click);
            // 
            // menuItemFoto
            // 
            this.menuItemFoto.Text = "Foto";
            this.menuItemFoto.Click += new System.EventHandler(this.menuItemFoto_Click);
            // 
            // listView1
            // 
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(234, 262);
            this.listView1.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemShow);
            this.contextMenu1.MenuItems.Add(this.menuItemDelete);
            // 
            // menuItemShow
            // 
            this.menuItemShow.Text = "anzeigen";
            this.menuItemShow.Click += new System.EventHandler(this.menuItemShow_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            // 
            // Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "Fotos";
            this.Text = "Fotos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItemFoto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemShow;
        private System.Windows.Forms.MenuItem menuItemDelete;
    }
}