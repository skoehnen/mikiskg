namespace PrototypMIS
{
    partial class Notiz
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
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemLink = new System.Windows.Forms.MenuItem();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.dataGridLinks = new System.Windows.Forms.DataGrid();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemShow = new System.Windows.Forms.MenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.MenuItem();
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
            this.menuItemBack.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItemSave);
            this.menuItemMenu.MenuItems.Add(this.menuItemDelete);
            this.menuItemMenu.MenuItems.Add(this.menuItemLink);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemSave
            // 
            this.menuItemSave.Text = "speichern";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemLink
            // 
            this.menuItemLink.Text = "Verlinken";
            this.menuItemLink.Click += new System.EventHandler(this.menuItemLink_Click);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(39, 8);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(198, 25);
            this.textBoxTitel.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(3, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(30, 20);
            this.labelTitle.Text = "Titel";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(3, 35);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(234, 129);
            this.textBoxText.TabIndex = 2;
            // 
            // dataGridLinks
            // 
            this.dataGridLinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridLinks.ContextMenu = this.contextMenu1;
            this.dataGridLinks.Location = new System.Drawing.Point(3, 170);
            this.dataGridLinks.Name = "dataGridLinks";
            this.dataGridLinks.Size = new System.Drawing.Size(234, 95);
            this.dataGridLinks.TabIndex = 4;
            this.dataGridLinks.GotFocus += new System.EventHandler(this.Notiz_GotFocus);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.contextMenuItemShow);
            this.contextMenu1.MenuItems.Add(this.contextMenuItemDelete);
            // 
            // contextMenuItemShow
            // 
            this.contextMenuItemShow.Text = "Anzeigen";
            this.contextMenuItemShow.Click += new System.EventHandler(this.contextMenuItemShow_Click);
            // 
            // contextMenuItemDelete
            // 
            this.contextMenuItemDelete.Text = "Löschen";
            this.contextMenuItemDelete.Click += new System.EventHandler(this.contextMenuItemDelete_Click);
            // 
            // Notiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGridLinks);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitel);
            this.Menu = this.mainMenu1;
            this.Name = "Notiz";
            this.Text = "Notiz";
            this.GotFocus += new System.EventHandler(this.Notiz_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.DataGrid dataGridLinks;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem contextMenuItemShow;
        private System.Windows.Forms.MenuItem contextMenuItemDelete;
        private System.Windows.Forms.MenuItem menuItemLink;
    }
}