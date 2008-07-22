namespace PrototypMIS
{
    partial class TermineList
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
            this.menuItemBack = new System.Windows.Forms.MenuItem();
            this.menuItemMenu = new System.Windows.Forms.MenuItem();
            this.menuItemSearch = new System.Windows.Forms.MenuItem();
            this.menuItemNewAppointment = new System.Windows.Forms.MenuItem();
            this.listViewTermine = new System.Windows.Forms.ListView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemDeleteListItem = new System.Windows.Forms.MenuItem();
            this.menuItemShowListItem = new System.Windows.Forms.MenuItem();
            this.menuItemLinkToItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemBack);
            this.mainMenu1.MenuItems.Add(this.menuItemMenu);
            // 
            // menuItemBack
            // 
            this.menuItemBack.Text = "zurück";
            this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItemSearch);
            this.menuItemMenu.MenuItems.Add(this.menuItemNewAppointment);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Text = "suchen";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItemNewAppointment
            // 
            this.menuItemNewAppointment.Text = "Termin anlegen";
            this.menuItemNewAppointment.Click += new System.EventHandler(this.menuItemNewAppointment_Click);
            // 
            // listViewTermine
            // 
            this.listViewTermine.ContextMenu = this.contextMenu1;
            this.listViewTermine.Location = new System.Drawing.Point(0, 0);
            this.listViewTermine.Name = "listViewTermine";
            this.listViewTermine.Size = new System.Drawing.Size(240, 268);
            this.listViewTermine.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemDeleteListItem);
            this.contextMenu1.MenuItems.Add(this.menuItemShowListItem);
            this.contextMenu1.MenuItems.Add(this.menuItemLinkToItem);
            // 
            // menuItemDeleteListItem
            // 
            this.menuItemDeleteListItem.Text = "löschen";
            this.menuItemDeleteListItem.Click += new System.EventHandler(this.menuItemDeleteListItem_Click);
            // 
            // menuItemShowListItem
            // 
            this.menuItemShowListItem.Text = "anzeigen";
            this.menuItemShowListItem.Click += new System.EventHandler(this.menuItemShowListItem_Click);
            // 
            // menuItemLinkToItem
            // 
            this.menuItemLinkToItem.Text = "verlinken";
            this.menuItemLinkToItem.Click += new System.EventHandler(this.menuItemLinkToItem_Click);
            // 
            // TermineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listViewTermine);
            this.Menu = this.mainMenu1;
            this.Name = "TermineList";
            this.Text = "Termine";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTermine;
        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemDeleteListItem;
        private System.Windows.Forms.MenuItem menuItemShowListItem;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.MenuItem menuItemNewAppointment;
        private System.Windows.Forms.MenuItem menuItemLinkToItem;
    }
}