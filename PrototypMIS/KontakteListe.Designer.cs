namespace PrototypMIS
{
    partial class KontakteListe
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
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemContactCreate = new System.Windows.Forms.MenuItem();
            this.menuItemSearch = new System.Windows.Forms.MenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemShow = new System.Windows.Forms.MenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemLinkToItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemBack);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItemBack
            // 
            this.menuItemBack.Text = "zurück";
            this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItemContactCreate);
            this.menuItem2.MenuItems.Add(this.menuItemSearch);
            this.menuItem2.Text = "Menü";
            // 
            // menuItemContactCreate
            // 
            this.menuItemContactCreate.Text = "Kontakt Anlegen";
            this.menuItemContactCreate.Click += new System.EventHandler(this.menuItemContactCreate_Click);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Text = "Suchen";
            // 
            // listView1
            // 
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 262);
            this.listView1.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.contextMenuItemShow);
            this.contextMenu1.MenuItems.Add(this.contextMenuItemDelete);
            this.contextMenu1.MenuItems.Add(this.menuItemLinkToItem);
            // 
            // contextMenuItemShow
            // 
            this.contextMenuItemShow.Text = "Anzeigen";
            this.contextMenuItemShow.Click += new System.EventHandler(this.contextMenuItemShow_Click);
            // 
            // contextMenuItemDelete
            // 
            this.contextMenuItemDelete.Text = "Löchen";
            this.contextMenuItemDelete.Click += new System.EventHandler(this.contextMenuItemDelete_Click);
            // 
            // menuItemLinkToItem
            // 
            this.menuItemLinkToItem.Text = "Verlinken";
            this.menuItemLinkToItem.Click += new System.EventHandler(this.menuItemLinkToItem_Click);
            // 
            // KontakteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "KontakteListe";
            this.Text = "Kontakte";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemContactCreate;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem contextMenuItemShow;
        private System.Windows.Forms.MenuItem contextMenuItemDelete;
        private System.Windows.Forms.MenuItem menuItemLinkToItem;
    }
}