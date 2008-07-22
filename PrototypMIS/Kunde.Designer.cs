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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGrid_kundenauftraege = new System.Windows.Forms.DataGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGrid2 = new System.Windows.Forms.DataGrid();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage5);
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
            this.tabPage1.Size = new System.Drawing.Size(240, 238);
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
            this.textBox_hausnr.Size = new System.Drawing.Size(140, 25);
            this.textBox_hausnr.TabIndex = 6;
            // 
            // textBox_knr
            // 
            this.textBox_knr.Enabled = false;
            this.textBox_knr.Location = new System.Drawing.Point(93, 193);
            this.textBox_knr.Name = "textBox_knr";
            this.textBox_knr.Size = new System.Drawing.Size(140, 25);
            this.textBox_knr.TabIndex = 5;
            // 
            // textBox_straße
            // 
            this.textBox_straße.Enabled = false;
            this.textBox_straße.Location = new System.Drawing.Point(93, 139);
            this.textBox_straße.Name = "textBox_straße";
            this.textBox_straße.Size = new System.Drawing.Size(140, 25);
            this.textBox_straße.TabIndex = 4;
            // 
            // textBox_plz
            // 
            this.textBox_plz.Enabled = false;
            this.textBox_plz.Location = new System.Drawing.Point(93, 112);
            this.textBox_plz.Name = "textBox_plz";
            this.textBox_plz.Size = new System.Drawing.Size(140, 25);
            this.textBox_plz.TabIndex = 3;
            // 
            // textBox_nachname
            // 
            this.textBox_nachname.Enabled = false;
            this.textBox_nachname.Location = new System.Drawing.Point(93, 85);
            this.textBox_nachname.Name = "textBox_nachname";
            this.textBox_nachname.Size = new System.Drawing.Size(140, 25);
            this.textBox_nachname.TabIndex = 2;
            // 
            // textBox_vorname
            // 
            this.textBox_vorname.Enabled = false;
            this.textBox_vorname.Location = new System.Drawing.Point(93, 58);
            this.textBox_vorname.Name = "textBox_vorname";
            this.textBox_vorname.Size = new System.Drawing.Size(140, 25);
            this.textBox_vorname.TabIndex = 1;
            // 
            // textBox_anrede
            // 
            this.textBox_anrede.Enabled = false;
            this.textBox_anrede.Location = new System.Drawing.Point(93, 31);
            this.textBox_anrede.Name = "textBox_anrede";
            this.textBox_anrede.Size = new System.Drawing.Size(140, 25);
            this.textBox_anrede.TabIndex = 0;
            this.textBox_anrede.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrid1);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(232, 236);
            this.tabPage2.Text = "Verbindungen";
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
            this.menuItem2.Text = "anzeigen";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGrid_kundenauftraege);
            this.tabPage5.Location = new System.Drawing.Point(0, 0);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(240, 238);
            this.tabPage5.Text = "Aufträge";
            // 
            // dataGrid_kundenauftraege
            // 
            this.dataGrid_kundenauftraege.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid_kundenauftraege.Location = new System.Drawing.Point(4, 4);
            this.dataGrid_kundenauftraege.Name = "dataGrid_kundenauftraege";
            this.dataGrid_kundenauftraege.Size = new System.Drawing.Size(229, 226);
            this.dataGrid_kundenauftraege.TabIndex = 0;
            this.dataGrid_kundenauftraege.CurrentCellChanged += new System.EventHandler(this.dataGrid_kundenauftraege_CurrentCellChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Location = new System.Drawing.Point(0, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(240, 242);
            this.tabPage3.Text = "Kundendaten";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.Text = "K-Nummer";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.Text = "Hausnummer";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(7, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.Text = "Straße";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.Text = "PLZ";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.Text = "Nachname";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.Text = "Vorname";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 20);
            this.label14.Text = "Anrede";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(93, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 25);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(93, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(93, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 25);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(93, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 25);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(93, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 25);
            this.textBox5.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(93, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 25);
            this.textBox6.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(93, 31);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 25);
            this.textBox7.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGrid2);
            this.tabPage4.Location = new System.Drawing.Point(0, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(240, 242);
            this.tabPage4.Text = "Verknüpfte Objekte";
            // 
            // dataGrid2
            // 
            this.dataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataGrid2.ContextMenu = this.verknuepfte;
            this.dataGrid2.Location = new System.Drawing.Point(0, 0);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.Size = new System.Drawing.Size(240, 239);
            this.dataGrid2.TabIndex = 0;
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
            this.tabPage5.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGrid dataGrid2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGrid dataGrid_kundenauftraege;
    }
}