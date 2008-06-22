namespace PrototypMIS
{
    partial class Aufgaben
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
            this.menuItemAufgabeAnlegen = new System.Windows.Forms.MenuItem();
            this.menuItemSuchen = new System.Windows.Forms.MenuItem();
            this.dataGridAufgaben = new System.Windows.Forms.DataGrid();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
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
            this.menuItemMenu.MenuItems.Add(this.menuItemAufgabeAnlegen);
            this.menuItemMenu.MenuItems.Add(this.menuItemSuchen);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemAufgabeAnlegen
            // 
            this.menuItemAufgabeAnlegen.Text = "Aufgabe anlegen";
            this.menuItemAufgabeAnlegen.Click += new System.EventHandler(this.menuItemAufgabeAnlegen_Click);
            // 
            // menuItemSuchen
            // 
            this.menuItemSuchen.Text = "Suchen";
            // 
            // dataGridAufgaben
            // 
            this.dataGridAufgaben.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridAufgaben.ContextMenu = this.contextMenu1;
            this.dataGridAufgaben.Location = new System.Drawing.Point(0, 0);
            this.dataGridAufgaben.Name = "dataGridAufgaben";
            this.dataGridAufgaben.Size = new System.Drawing.Size(240, 265);
            this.dataGridAufgaben.TabIndex = 0;
            this.dataGridAufgaben.CurrentCellChanged += new System.EventHandler(this.dataGrid1_CurrentCellChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemDelete);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "Löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // Aufgaben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGridAufgaben);
            this.Menu = this.mainMenu1;
            this.Name = "Aufgaben";
            this.Text = "Aufgaben";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGridAufgaben;
        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemAufgabeAnlegen;
        private System.Windows.Forms.MenuItem menuItemSuchen;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemDelete;
    }
}