namespace PrototypMIS
{
    partial class Termine
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
            this.menuItemTerminAnlegen = new System.Windows.Forms.MenuItem();
            this.menuItemSuchen = new System.Windows.Forms.MenuItem();
            this.dataGridAppointments = new System.Windows.Forms.DataGrid();
            this.contextMenuTermine = new System.Windows.Forms.ContextMenu();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemAnzeigen = new System.Windows.Forms.MenuItem();
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
            this.menuItemMenu.MenuItems.Add(this.menuItemTerminAnlegen);
            this.menuItemMenu.MenuItems.Add(this.menuItemSuchen);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemTerminAnlegen
            // 
            this.menuItemTerminAnlegen.Text = "Termin anlegen";
            this.menuItemTerminAnlegen.Click += new System.EventHandler(this.menuItemTerminAnlegen_Click);
            // 
            // menuItemSuchen
            // 
            this.menuItemSuchen.Text = "Suchen";
            // 
            // dataGridAppointments
            // 
            this.dataGridAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridAppointments.ContextMenu = this.contextMenuTermine;
            this.dataGridAppointments.Location = new System.Drawing.Point(0, 3);
            this.dataGridAppointments.Name = "dataGridAppointments";
            this.dataGridAppointments.Size = new System.Drawing.Size(240, 262);
            this.dataGridAppointments.TabIndex = 0;
            this.dataGridAppointments.CurrentCellChanged += new System.EventHandler(this.dataGridAppointments_CurrentCellChanged);
            // 
            // contextMenuTermine
            // 
            this.contextMenuTermine.MenuItems.Add(this.menuItemDelete);
            this.contextMenuTermine.MenuItems.Add(this.menuItemAnzeigen);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "Löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemAnzeigen
            // 
            this.menuItemAnzeigen.Text = "anzeigen";
            this.menuItemAnzeigen.Click += new System.EventHandler(this.menuItemAnzeigen_Click);
            // 
            // Termine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGridAppointments);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "Termine";
            this.Text = "Termine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGridAppointments;
        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemTerminAnlegen;
        private System.Windows.Forms.MenuItem menuItemSuchen;
        private System.Windows.Forms.ContextMenu contextMenuTermine;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.MenuItem menuItemAnzeigen;
    }
}