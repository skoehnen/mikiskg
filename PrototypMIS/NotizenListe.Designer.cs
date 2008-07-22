namespace PrototypMIS
{
    partial class NotizenListe
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
            this.menuItemNewNote = new System.Windows.Forms.MenuItem();
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItemShowSelectedItem = new System.Windows.Forms.MenuItem();
            this.menuItemDeleteSelectedItem = new System.Windows.Forms.MenuItem();
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
            this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click_1);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItemSearch);
            this.menuItemMenu.MenuItems.Add(this.menuItemNewNote);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemSearch
            // 
            this.menuItemSearch.Text = "suchen";
            this.menuItemSearch.Click += new System.EventHandler(this.menuItemSearch_Click);
            // 
            // menuItemNewNote
            // 
            this.menuItemNewNote.Text = "Notiz anlegen";
            this.menuItemNewNote.Click += new System.EventHandler(this.menuItemNewNote_Click);
            // 
            // listViewNotes
            // 
            this.listViewNotes.ContextMenu = this.contextMenu1;
            this.listViewNotes.Location = new System.Drawing.Point(0, 0);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(240, 268);
            this.listViewNotes.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.menuItemShowSelectedItem);
            this.contextMenu1.MenuItems.Add(this.menuItemDeleteSelectedItem);
            this.contextMenu1.MenuItems.Add(this.menuItemLinkToItem);
            // 
            // menuItemShowSelectedItem
            // 
            this.menuItemShowSelectedItem.Text = "anzeigen";
            this.menuItemShowSelectedItem.Click += new System.EventHandler(this.menuItemShowSelectedItem_Click);
            // 
            // menuItemDeleteSelectedItem
            // 
            this.menuItemDeleteSelectedItem.Text = "löschen";
            this.menuItemDeleteSelectedItem.Click += new System.EventHandler(this.menuItemDeleteSelectedItem_Click);
            // 
            // menuItemLinkToItem
            // 
            this.menuItemLinkToItem.Text = "verlinken";
            this.menuItemLinkToItem.Click += new System.EventHandler(this.menuItemLinkToItem_Click);
            // 
            // NotizenListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.listViewNotes);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "NotizenListe";
            this.Text = "NotizenListe";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotizenListe_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewNotes;
        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemSearch;
        private System.Windows.Forms.MenuItem menuItemNewNote;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem menuItemShowSelectedItem;
        private System.Windows.Forms.MenuItem menuItemDeleteSelectedItem;
        private System.Windows.Forms.MenuItem menuItemLinkToItem;
    }
}