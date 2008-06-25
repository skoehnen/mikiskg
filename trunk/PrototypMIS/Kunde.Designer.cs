namespace PrototypMIS
{
    partial class Kunde
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_hausnr = new System.Windows.Forms.TextBox();
            this.textBox_knr = new System.Windows.Forms.TextBox();
            this.textBox_straße = new System.Windows.Forms.TextBox();
            this.textBox_plz = new System.Windows.Forms.TextBox();
            this.textBox_nachname = new System.Windows.Forms.TextBox();
            this.textBox_vorname = new System.Windows.Forms.TextBox();
            this.textBox_anrede = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.verknuepfte = new System.Windows.Forms.ContextMenu();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_hausnr);
            this.tabPage1.Controls.Add(this.textBox_knr);
            this.tabPage1.Controls.Add(this.textBox_straße);
            this.tabPage1.Controls.Add(this.textBox_plz);
            this.tabPage1.Controls.Add(this.textBox_nachname);
            this.tabPage1.Controls.Add(this.textBox_vorname);
            this.tabPage1.Controls.Add(this.textBox_anrede);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 242);
            this.tabPage1.Text = "Kundendaten";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.Text = "K-Nummer";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.Text = "Hausnummer";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.Text = "Straße";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.Text = "PLZ";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.Text = "Nachname";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.Text = "Vorname";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.Text = "Anrede";
            // 
            // textBox_hausnr
            // 
            this.textBox_hausnr.Enabled = false;
            this.textBox_hausnr.Location = new System.Drawing.Point(93, 166);
            this.textBox_hausnr.Name = "textBox_hausnr";
            this.textBox_hausnr.Size = new System.Drawing.Size(140, 21);
            this.textBox_hausnr.TabIndex = 6;
            // 
            // textBox_knr
            // 
            this.textBox_knr.Enabled = false;
            this.textBox_knr.Location = new System.Drawing.Point(93, 193);
            this.textBox_knr.Name = "textBox_knr";
            this.textBox_knr.Size = new System.Drawing.Size(140, 21);
            this.textBox_knr.TabIndex = 5;
            // 
            // textBox_straße
            // 
            this.textBox_straße.Enabled = false;
            this.textBox_straße.Location = new System.Drawing.Point(93, 139);
            this.textBox_straße.Name = "textBox_straße";
            this.textBox_straße.Size = new System.Drawing.Size(140, 21);
            this.textBox_straße.TabIndex = 4;
            // 
            // textBox_plz
            // 
            this.textBox_plz.Enabled = false;
            this.textBox_plz.Location = new System.Drawing.Point(93, 112);
            this.textBox_plz.Name = "textBox_plz";
            this.textBox_plz.Size = new System.Drawing.Size(140, 21);
            this.textBox_plz.TabIndex = 3;
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Enabled = false;
            this.textBox_nachname.Location = new System.Drawing.Point(93, 85);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(140, 21);
            this.textBox_nachname.TabIndex = 2;
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Enabled = false;
            this.textBox_vorname.Location = new System.Drawing.Point(93, 58);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(140, 21);
            this.textBox_vorname.TabIndex = 1;
            // 
            // textBox_anrede
            // 
            this.textBox_anrede.Enabled = false;
            this.textBox_anrede.Location = new System.Drawing.Point(93, 31);
            this.textBox_anrede.Name = "textBox_anrede";
            this.textBox_anrede.Size = new System.Drawing.Size(140, 21);
            this.textBox_anrede.TabIndex = 0;
            this.textBox_anrede.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrid1);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 239);
            this.tabPage2.Text = "Verknüpfte Objekte";
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid1.ContextMenu = this.verknuepfte;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(240, 239);
            this.dataGrid1.TabIndex = 0;
            // 
            // verknuepfte
            // 
            this.verknuepfte.MenuItems.Add(this.menuItem2);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Anzeigen";
            // 
            // Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.tabControl1);
            this.Menu = this.mainMenu1;
            this.Name = "Kunde";
            this.Text = "Kunde";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemBack;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_hausnr;
        private System.Windows.Forms.TextBox textBox_knr;
        private System.Windows.Forms.TextBox textBox_straße;
        private System.Windows.Forms.TextBox textBox_plz;
        private System.Windows.Forms.TextBox textBox_nachname;
        private System.Windows.Forms.TextBox textBox_vorname;
        private System.Windows.Forms.TextBox textBox_anrede;
        private System.Windows.Forms.ContextMenu verknuepfte;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}