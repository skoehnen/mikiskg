namespace PrototypMIS
{
    partial class Foto
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
            this.menuItemAbbrechen = new System.Windows.Forms.MenuItem();
            this.menuItemMenu = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItemDelete = new System.Windows.Forms.MenuItem();
            this.menuItemLink = new System.Windows.Forms.MenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFoto = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTitel = new System.Windows.Forms.TextBox();
            this.tabPageBeschreibung = new System.Windows.Forms.TabPage();
            this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.tabPageLinks = new System.Windows.Forms.TabPage();
            this.dataGridLinks = new System.Windows.Forms.DataGrid();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemShow = new System.Windows.Forms.MenuItem();
            this.contextMenuItemDelete = new System.Windows.Forms.MenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageFoto.SuspendLayout();
            this.tabPageBeschreibung.SuspendLayout();
            this.tabPageLinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemAbbrechen);
            this.mainMenu1.MenuItems.Add(this.menuItemMenu);
            // 
            // menuItemAbbrechen
            // 
            this.menuItemAbbrechen.Text = "abbrechen";
            this.menuItemAbbrechen.Click += new System.EventHandler(this.menuItemAbbrechen_Click);
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
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSpeichern_Click);
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.Text = "löschen";
            this.menuItemDelete.Click += new System.EventHandler(this.menuItemDelete_Click);
            // 
            // menuItemLink
            // 
            this.menuItemLink.Text = "verlinken";
            this.menuItemLink.Click += new System.EventHandler(this.menuItemLink_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFoto);
            this.tabControl1.Controls.Add(this.tabPageBeschreibung);
            this.tabControl1.Controls.Add(this.tabPageLinks);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 268);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFoto
            // 
            this.tabPageFoto.Controls.Add(this.pictureBox1);
            this.tabPageFoto.Controls.Add(this.textBoxTitel);
            this.tabPageFoto.Location = new System.Drawing.Point(0, 0);
            this.tabPageFoto.Name = "tabPageFoto";
            this.tabPageFoto.Size = new System.Drawing.Size(240, 241);
            this.tabPageFoto.Text = "Foto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 212);
            // 
            // textBoxTitel
            // 
            this.textBoxTitel.Location = new System.Drawing.Point(3, 3);
            this.textBoxTitel.Name = "textBoxTitel";
            this.textBoxTitel.Size = new System.Drawing.Size(234, 25);
            this.textBoxTitel.TabIndex = 0;
            // 
            // tabPageBeschreibung
            // 
            this.tabPageBeschreibung.Controls.Add(this.textBoxBeschreibung);
            this.tabPageBeschreibung.Location = new System.Drawing.Point(0, 0);
            this.tabPageBeschreibung.Name = "tabPageBeschreibung";
            this.tabPageBeschreibung.Size = new System.Drawing.Size(232, 239);
            this.tabPageBeschreibung.Text = "Beschreibung";
            // 
            // textBoxBeschreibung
            // 
            this.textBoxBeschreibung.Location = new System.Drawing.Point(3, 3);
            this.textBoxBeschreibung.Multiline = true;
            this.textBoxBeschreibung.Name = "textBoxBeschreibung";
            this.textBoxBeschreibung.Size = new System.Drawing.Size(230, 239);
            this.textBoxBeschreibung.TabIndex = 0;
            // 
            // tabPageLinks
            // 
            this.tabPageLinks.Controls.Add(this.dataGridLinks);
            this.tabPageLinks.Location = new System.Drawing.Point(0, 0);
            this.tabPageLinks.Name = "tabPageLinks";
            this.tabPageLinks.Size = new System.Drawing.Size(232, 239);
            this.tabPageLinks.Text = "Verknüpfte Objekte";
            // 
            // dataGridLinks
            // 
            this.dataGridLinks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGridLinks.ContextMenu = this.contextMenu1;
            this.dataGridLinks.Location = new System.Drawing.Point(0, 3);
            this.dataGridLinks.Name = "dataGridLinks";
            this.dataGridLinks.Size = new System.Drawing.Size(240, 239);
            this.dataGridLinks.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.contextMenuItemShow);
            this.contextMenu1.MenuItems.Add(this.contextMenuItemDelete);
            // 
            // contextMenuItemShow
            // 
            this.contextMenuItemShow.Text = "anzeigen";
            this.contextMenuItemShow.Click += new System.EventHandler(this.contextMenuItemShow_Click);
            // 
            // contextMenuItemDelete
            // 
            this.contextMenuItemDelete.Text = "löschen";
            this.contextMenuItemDelete.Click += new System.EventHandler(this.contextMenuItemDelete_Click);
            // 
            // Foto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Foto";
            this.Text = "Foto";
            this.GotFocus += new System.EventHandler(this.Foto_GotFocus);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFoto.ResumeLayout(false);
            this.tabPageBeschreibung.ResumeLayout(false);
            this.tabPageLinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTitel;
        private System.Windows.Forms.TabPage tabPageBeschreibung;
        private System.Windows.Forms.TextBox textBoxBeschreibung;
        private System.Windows.Forms.MenuItem menuItemAbbrechen;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.TabPage tabPageLinks;
        private System.Windows.Forms.DataGrid dataGridLinks;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem contextMenuItemShow;
        private System.Windows.Forms.MenuItem contextMenuItemDelete;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItemDelete;
        private System.Windows.Forms.MenuItem menuItemLink;

    }
}