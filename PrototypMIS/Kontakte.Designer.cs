namespace PrototypMIS
{
    partial class Kontakte
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
            this.Menue = new System.Windows.Forms.MenuItem();
            this.menuItemSearch = new System.Windows.Forms.MenuItem();
            this.menuItemCreateContact = new System.Windows.Forms.MenuItem();
            this.menuItemFitColumnWidth = new System.Windows.Forms.MenuItem();
            this.dataGridKontakte = new System.Windows.Forms.DataGrid();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemShow = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            this.mainMenu1.MenuItems.Add(this.Menue);
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZurueck_Click);
            // 
            // Menue
            // 
            this.Menue.MenuItems.Add(this.menuItemSearch);
            this.Menue.MenuItems.Add(this.menuItemCreateContact);
            this.Menue.MenuItems.Add(this.menuItemFitColumnWidth);
            this.Menue.Text = "Menü";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Text = "Suchen";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItemCreateContact
            // 
            this.menuItemCreateContact.Text = "Kontakt anlegen";
            this.menuItemCreateContact.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // menuItemFitColumnWidth
            // 
            this.menuItemFitColumnWidth.Text = "Spaltenbreite anpassen";
            this.menuItemFitColumnWidth.Click += new System.EventHandler(this.menuItemFitColumnWidth_Click);
            // 
            // dataGridKontakte
            // 
            this.dataGridKontakte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridKontakte.ContextMenu = this.contextMenu1;
            this.dataGridKontakte.Location = new System.Drawing.Point(0, 0);
            this.dataGridKontakte.Name = "dataGridKontakte";
            this.dataGridKontakte.RowHeadersVisible = false;
            this.dataGridKontakte.Size = new System.Drawing.Size(240, 265);
            this.dataGridKontakte.TabIndex = 0;
            this.dataGridKontakte.CurrentCellChanged += new System.EventHandler(this.dataGridKontakte_CurrentCellChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemDelete);
            this.contextMenu1.MenuItems.Add(this.menuItemShow);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemShow
            // 
            this.menuItemShow.Text = "anzeigen";
            this.menuItemShow.Click += new System.EventHandler(this.menuItemShow_Click);
            // 
            // Kontakte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGridKontakte);
            this.Menu = this.mainMenu1;
            this.Name = "Kontakte";
            this.Text = "Kontakte";
            this.GotFocus += new System.EventHandler(this.gotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem Menue;
        private System.Windows.Forms.DataGrid dataGridKontakte;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.MenuItem menuItemCreateContact;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.MenuItem menuItemShow;
        private System.Windows.Forms.MenuItem menuItemFitColumnWidth;
    }
}