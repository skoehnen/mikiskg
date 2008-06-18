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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.dataGridKontakte = new System.Windows.Forms.DataGrid();
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
            this.Menue.MenuItems.Add(this.menuItem1);
            this.Menue.MenuItems.Add(this.menuItem2);
            this.Menue.Text = "Menü";
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Suchen";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Kontakt anlegen";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // dataGridKontakte
            // 
            this.dataGridKontakte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridKontakte.Location = new System.Drawing.Point(0, 0);
            this.dataGridKontakte.Name = "dataGridKontakte";
            this.dataGridKontakte.RowHeadersVisible = false;
            this.dataGridKontakte.Size = new System.Drawing.Size(240, 265);
            this.dataGridKontakte.TabIndex = 0;
            this.dataGridKontakte.CurrentCellChanged += new System.EventHandler(this.dataGridKontakte_CurrentCellChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem Menue;
        private System.Windows.Forms.DataGrid dataGridKontakte;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}