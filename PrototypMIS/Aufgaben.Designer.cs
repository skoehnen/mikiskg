﻿namespace PrototypMIS
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
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.menuItemZurueck = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItemAufgabeAnlegen = new System.Windows.Forms.MenuItem();
            this.menuItemSuchen = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 265);
            this.dataGrid1.TabIndex = 0;
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZurueck_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.MenuItems.Add(this.menuItemAufgabeAnlegen);
            this.menuItem2.MenuItems.Add(this.menuItemSuchen);
            this.menuItem2.Text = "Suchen";
            // 
            // menuItemAufgabeAnlegen
            // 
            this.menuItemAufgabeAnlegen.Text = "Aufgabe anlegen";
            // 
            // menuItemSuchen
            // 
            this.menuItemSuchen.Text = "Suchen";
            // 
            // Aufgaben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dataGrid1);
            this.Menu = this.mainMenu1;
            this.Name = "Aufgaben";
            this.Text = "Aufgaben";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItemAufgabeAnlegen;
        private System.Windows.Forms.MenuItem menuItemSuchen;
    }
}