namespace PrototypMIS
{
    partial class Suchen
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
            this.textBoxSuchen = new System.Windows.Forms.TextBox();
            this.labelSuchen = new System.Windows.Forms.Label();
            this.checkBoxAufgaben = new System.Windows.Forms.CheckBox();
            this.checkBoxNotizen = new System.Windows.Forms.CheckBox();
            this.checkBoxTermine = new System.Windows.Forms.CheckBox();
            this.checkBoxKontakte = new System.Windows.Forms.CheckBox();
            this.checkBoxKunden = new System.Windows.Forms.CheckBox();
            this.checkBoxFotos = new System.Windows.Forms.CheckBox();
            this.checkBoxAuftraege = new System.Windows.Forms.CheckBox();
            this.buttonSuchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemZurueck);
            // 
            // menuItemZurueck
            // 
            this.menuItemZurueck.Text = "zurück";
            this.menuItemZurueck.Click += new System.EventHandler(this.menuItemZurueck_Click);
            // 
            // textBoxSuchen
            // 
            this.textBoxSuchen.Location = new System.Drawing.Point(65, 3);
            this.textBoxSuchen.Name = "textBoxSuchen";
            this.textBoxSuchen.Size = new System.Drawing.Size(175, 25);
            this.textBoxSuchen.TabIndex = 0;
            // 
            // labelSuchen
            // 
            this.labelSuchen.Location = new System.Drawing.Point(5, 4);
            this.labelSuchen.Name = "labelSuchen";
            this.labelSuchen.Size = new System.Drawing.Size(54, 20);
            this.labelSuchen.Text = "Suchen";
            // 
            // checkBoxAufgaben
            // 
            this.checkBoxAufgaben.Location = new System.Drawing.Point(27, 47);
            this.checkBoxAufgaben.Name = "checkBoxAufgaben";
            this.checkBoxAufgaben.Size = new System.Drawing.Size(100, 20);
            this.checkBoxAufgaben.TabIndex = 2;
            this.checkBoxAufgaben.Text = "Aufgaben";
            // 
            // checkBoxNotizen
            // 
            this.checkBoxNotizen.Location = new System.Drawing.Point(27, 73);
            this.checkBoxNotizen.Name = "checkBoxNotizen";
            this.checkBoxNotizen.Size = new System.Drawing.Size(100, 20);
            this.checkBoxNotizen.TabIndex = 3;
            this.checkBoxNotizen.Text = "Notizen";
            // 
            // checkBoxTermine
            // 
            this.checkBoxTermine.Location = new System.Drawing.Point(27, 99);
            this.checkBoxTermine.Name = "checkBoxTermine";
            this.checkBoxTermine.Size = new System.Drawing.Size(100, 20);
            this.checkBoxTermine.TabIndex = 4;
            this.checkBoxTermine.Text = "Termine";
            // 
            // checkBoxKontakte
            // 
            this.checkBoxKontakte.Location = new System.Drawing.Point(27, 122);
            this.checkBoxKontakte.Name = "checkBoxKontakte";
            this.checkBoxKontakte.Size = new System.Drawing.Size(100, 20);
            this.checkBoxKontakte.TabIndex = 5;
            this.checkBoxKontakte.Text = "Kontakte";
            // 
            // checkBoxKunden
            // 
            this.checkBoxKunden.Location = new System.Drawing.Point(27, 148);
            this.checkBoxKunden.Name = "checkBoxKunden";
            this.checkBoxKunden.Size = new System.Drawing.Size(100, 20);
            this.checkBoxKunden.TabIndex = 6;
            this.checkBoxKunden.Text = "Kunden";
            // 
            // checkBoxFotos
            // 
            this.checkBoxFotos.Location = new System.Drawing.Point(27, 200);
            this.checkBoxFotos.Name = "checkBoxFotos";
            this.checkBoxFotos.Size = new System.Drawing.Size(100, 20);
            this.checkBoxFotos.TabIndex = 7;
            this.checkBoxFotos.Text = "Fotos";
            // 
            // checkBoxAuftraege
            // 
            this.checkBoxAuftraege.Location = new System.Drawing.Point(27, 174);
            this.checkBoxAuftraege.Name = "checkBoxAuftraege";
            this.checkBoxAuftraege.Size = new System.Drawing.Size(100, 20);
            this.checkBoxAuftraege.TabIndex = 8;
            this.checkBoxAuftraege.Text = "Aufträge";
            // 
            // buttonSuchen
            // 
            this.buttonSuchen.Location = new System.Drawing.Point(131, 47);
            this.buttonSuchen.Name = "buttonSuchen";
            this.buttonSuchen.Size = new System.Drawing.Size(108, 172);
            this.buttonSuchen.TabIndex = 9;
            this.buttonSuchen.Text = "Suchen";
            this.buttonSuchen.Click += new System.EventHandler(this.buttonSuchen_Click);
            // 
            // Suchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.buttonSuchen);
            this.Controls.Add(this.checkBoxAuftraege);
            this.Controls.Add(this.checkBoxFotos);
            this.Controls.Add(this.checkBoxKunden);
            this.Controls.Add(this.checkBoxKontakte);
            this.Controls.Add(this.checkBoxTermine);
            this.Controls.Add(this.checkBoxNotizen);
            this.Controls.Add(this.checkBoxAufgaben);
            this.Controls.Add(this.labelSuchen);
            this.Controls.Add(this.textBoxSuchen);
            this.Menu = this.mainMenu1;
            this.Name = "Suchen";
            this.Text = "Suchen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSuchen;
        private System.Windows.Forms.Label labelSuchen;
        private System.Windows.Forms.CheckBox checkBoxAufgaben;
        private System.Windows.Forms.CheckBox checkBoxNotizen;
        private System.Windows.Forms.CheckBox checkBoxTermine;
        private System.Windows.Forms.CheckBox checkBoxKontakte;
        private System.Windows.Forms.CheckBox checkBoxKunden;
        private System.Windows.Forms.CheckBox checkBoxFotos;
        private System.Windows.Forms.CheckBox checkBoxAuftraege;
        private System.Windows.Forms.Button buttonSuchen;
        private System.Windows.Forms.MenuItem menuItemZurueck;
    }
}