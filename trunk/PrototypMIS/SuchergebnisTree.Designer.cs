namespace PrototypMIS
{
    partial class SuchergebnisTree
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.contextMenuItemShow = new System.Windows.Forms.MenuItem();
            this.contextMenuItemLink = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemBack);
            // 
            // menuItemBack
            // 
            this.menuItemBack.Text = "zurück";
            this.menuItemBack.Click += new System.EventHandler(this.menuItemBack_Click);
            // 
            // treeView1
            // 
            this.treeView1.ContextMenu = this.contextMenu1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(234, 265);
            this.treeView1.TabIndex = 0;
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.Add(this.contextMenuItemShow);
            this.contextMenu1.MenuItems.Add(this.contextMenuItemLink);
            // 
            // contextMenuItemShow
            // 
            this.contextMenuItemShow.Text = "Anzeigen";
            this.contextMenuItemShow.Click += new System.EventHandler(this.contextMenuItemShow_Click);
            // 
            // contextMenuItemLink
            // 
            this.contextMenuItemLink.Text = "Verlinken";
            this.contextMenuItemLink.Click += new System.EventHandler(this.contextMenuItemLink_Click);
            // 
            // SuchergebnisTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.treeView1);
            this.Menu = this.mainMenu1;
            this.Name = "SuchergebnisTree";
            this.Text = "SuchergebnisTree";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem contextMenuItemShow;
        private System.Windows.Forms.MenuItem contextMenuItemLink;
    }
}