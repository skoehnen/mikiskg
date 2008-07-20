namespace PrototypMIS
{
    partial class Aufgabe
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
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemLink = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.dataGridLinks = new System.Windows.Forms.DataGrid();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemShow = new System.Windows.Forms.MenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.MenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.menuItemMenu.MenuItems.Add(this.menuItemDelete);
            this.menuItemMenu.MenuItems.Add(this.menuItemLink);
            this.menuItemMenu.MenuItems.Add(this.menuItemSave);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "Löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemLink
            // 
            this.menuItemLink.Text = "Anhängen";
            this.menuItemLink.Click += new System.EventHandler(this.menuItemLink_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Text = "Speichern";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(90, 3);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(133, 21);
            this.textBoxTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.Text = "Titel";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.Text = "Fällig";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(3, 60);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(234, 67);
            this.textBoxDescription.TabIndex = 9;
            // 
            // dataGridLinks
            // 
            this.dataGridLinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridLinks.ContextMenu = this.contextMenu1;
            this.dataGridLinks.Location = new System.Drawing.Point(0, 133);
            this.dataGridLinks.Name = "dataGridLinks";
            this.dataGridLinks.Size = new System.Drawing.Size(240, 132);
            this.dataGridLinks.TabIndex = 11;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // Aufgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridLinks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitle);
            this.Menu = this.mainMenu1;
            this.Name = "Aufgabe";
            this.Text = "Aufgabe";
            this.GotFocus += new System.EventHandler(this.Aufgabe_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.MenuItem menuItemLink;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.DataGrid dataGridLinks;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem contextMenuItemShow;
        private System.Windows.Forms.MenuItem contextMenuItemDelete;
    }
}