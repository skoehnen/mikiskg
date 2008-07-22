namespace PrototypMIS
{
    partial class KontakteList
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
            this.menuItemCreateTask = new System.Windows.Forms.MenuItem();
            this.menuItemSearch = new System.Windows.Forms.MenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemShowEntry = new System.Windows.Forms.MenuItem();
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
            this.menuItem2.MenuItems.Add(this.menuItemCreateTask);
            this.menuItem2.MenuItems.Add(this.menuItemSearch);
            this.menuItem2.Text = "Menü";
            // 
            // menuItemCreateTask
            // 
            this.menuItemCreateTask.Text = "Aufgabe anlegen";
            this.menuItemCreateTask.Click += new System.EventHandler(this.menuItemCreateTask_Click);
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Text = "suchen";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // listView1
            // 
            this.listView1.ContextMenu = this.contextMenu1;
            this.listView1.Location = new System.Drawing.Point(0, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(240, 262);
            this.listView1.TabIndex = 0;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemDelete);
            this.contextMenu1.MenuItems.Add(this.menuItemShowEntry);
            this.contextMenu1.MenuItems.Add(this.menuItemLinkToItem);
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemShowEntry
            // 
            this.menuItemShowEntry.Text = "anzeigen";
            this.menuItemShowEntry.Click += new System.EventHandler(this.menuItemShowEntry_Click);
            // 
            // menuItemLinkToItem
            // 
            this.menuItemLinkToItem.Text = "verlinken";
            this.menuItemLinkToItem.Click += new System.EventHandler(this.menuItemLinkToItem_Click);
            // 
            // KontakteList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listView1);
            this.Menu = this.mainMenu1;
            this.Name = "KontakteList";
            this.Text = "Aufgaben";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemCreateTask;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.MenuItem menuItemShowEntry;
        private System.Windows.Forms.MenuItem menuItemLinkToItem;
    }
}