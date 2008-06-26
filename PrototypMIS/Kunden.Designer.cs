namespace PrototypMIS
{
    partial class Kunden
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
            this.menuItemZurueck = new System.Windows.Forms.MenuItem();
            this.menuItemMenu = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Kundeneingabe = new System.Windows.Forms.ComboBox();
            this.textBox_kundendaten = new System.Windows.Forms.TextBox();
            this.button_suche = new System.Windows.Forms.Button();
            this.listBox_kunden = new System.Windows.Forms.ListBox();
            this.button_uebernahme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            this.mainMenu1.MenuItems.Add(this.menuItemMenu);
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZurueck_Click);
            // 
            // menuItemMenu
            // 
            this.menuItemMenu.MenuItems.Add(this.menuItem3);
            this.menuItemMenu.MenuItems.Add(this.menuItem4);
            this.menuItemMenu.Text = "Menü";
            // 
            // menuItem3
            // 
            this.menuItem3.Text = "Suchen";
            // 
            // menuItem4
            // 
            this.menuItem4.Text = "anzeigen";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(72, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.Text = "Kundensuche";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 39);
            this.label2.Text = "Kundenummer oder Kundennamen eingeben";
            // 
            // comboBox_Kundeneingabe
            // 
            this.comboBox_Kundeneingabe.Items.Add("Kundennummer");
            this.comboBox_Kundeneingabe.Items.Add("Kundenname");
            this.comboBox_Kundeneingabe.Location = new System.Drawing.Point(6, 58);
            this.comboBox_Kundeneingabe.Name = "comboBox_Kundeneingabe";
            this.comboBox_Kundeneingabe.Size = new System.Drawing.Size(107, 22);
            this.comboBox_Kundeneingabe.TabIndex = 4;
            this.comboBox_Kundeneingabe.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kundeneingabe_SelectedIndexChanged);
            // 
            // textBox_kundendaten
            // 
            this.textBox_kundendaten.Location = new System.Drawing.Point(120, 58);
            this.textBox_kundendaten.Name = "textBox_kundendaten";
            this.textBox_kundendaten.Size = new System.Drawing.Size(100, 21);
            this.textBox_kundendaten.TabIndex = 5;
            this.textBox_kundendaten.TextChanged += new System.EventHandler(this.textBox_kundendaten_TextChanged);
            // 
            // button_suche
            // 
            this.button_suche.Location = new System.Drawing.Point(84, 89);
            this.button_suche.Name = "button_suche";
            this.button_suche.Size = new System.Drawing.Size(72, 20);
            this.button_suche.TabIndex = 6;
            this.button_suche.Text = "suchen";
            this.button_suche.Click += new System.EventHandler(this.button_suche_Click);
            // 
            // listBox_kunden
            // 
            this.listBox_kunden.Location = new System.Drawing.Point(6, 118);
            this.listBox_kunden.Name = "listBox_kunden";
            this.listBox_kunden.Size = new System.Drawing.Size(231, 100);
            this.listBox_kunden.TabIndex = 9;
            this.listBox_kunden.Visible = false;
            this.listBox_kunden.SelectedIndexChanged += new System.EventHandler(this.listBox_kunden_SelectedIndexChanged);
            // 
            // button_uebernahme
            // 
            this.button_uebernahme.Location = new System.Drawing.Point(75, 225);
            this.button_uebernahme.Name = "button_uebernahme";
            this.button_uebernahme.Size = new System.Drawing.Size(84, 20);
            this.button_uebernahme.TabIndex = 12;
            this.button_uebernahme.Text = "übernehmen";
            this.button_uebernahme.Click += new System.EventHandler(this.button_uebernahme_Click);
            // 
            // Kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button_uebernahme);
            this.Controls.Add(this.listBox_kunden);
            this.Controls.Add(this.button_suche);
            this.Controls.Add(this.textBox_kundendaten);
            this.Controls.Add(this.comboBox_Kundeneingabe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Kunden";
            this.Text = "Kunden";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItemZurueck;
        private System.Windows.Forms.MenuItem menuItemMenu;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Kundeneingabe;
        private System.Windows.Forms.TextBox textBox_kundendaten;
        private System.Windows.Forms.Button button_suche;
        private System.Windows.Forms.ListBox listBox_kunden;
        private System.Windows.Forms.Button button_uebernahme;
    }
}