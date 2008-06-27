namespace PrototypMIS
{
    partial class Main
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
            this.menuItemShutApplication = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.buttonNotizen = new System.Windows.Forms.Button();
            this.buttonTermine = new System.Windows.Forms.Button();
            this.buttonKontakte = new System.Windows.Forms.Button();
            this.buttonKunden = new System.Windows.Forms.Button();
            this.buttonAuftraege = new System.Windows.Forms.Button();
            this.buttonFotos = new System.Windows.Forms.Button();
            this.buttonAufgaben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItemShutApplication);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItemShutApplication
            // 
            this.menuItemShutApplication.Text = "Beenden";
            this.menuItemShutApplication.Click += new System.EventHandler(this.menuItemShutApplication_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Suchen";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // buttonNotizen
            // 
            this.buttonNotizen.Location = new System.Drawing.Point(3, 42);
            this.buttonNotizen.Name = "buttonNotizen";
            this.buttonNotizen.Size = new System.Drawing.Size(234, 32);
            this.buttonNotizen.TabIndex = 0;
            this.buttonNotizen.Text = "Notizen";
            this.buttonNotizen.Click += new System.EventHandler(this.buttonNotizen_Click);
            // 
            // buttonTermine
            // 
            this.buttonTermine.Location = new System.Drawing.Point(3, 78);
            this.buttonTermine.Name = "buttonTermine";
            this.buttonTermine.Size = new System.Drawing.Size(234, 32);
            this.buttonTermine.TabIndex = 1;
            this.buttonTermine.Text = "Termine";
            this.buttonTermine.Click += new System.EventHandler(this.buttonTermine_Click);
            // 
            // buttonKontakte
            // 
            this.buttonKontakte.Location = new System.Drawing.Point(3, 114);
            this.buttonKontakte.Name = "buttonKontakte";
            this.buttonKontakte.Size = new System.Drawing.Size(234, 32);
            this.buttonKontakte.TabIndex = 2;
            this.buttonKontakte.Text = "Kontakte";
            this.buttonKontakte.Click += new System.EventHandler(this.buttonKontakte_Click);
            // 
            // buttonKunden
            // 
            this.buttonKunden.Location = new System.Drawing.Point(3, 150);
            this.buttonKunden.Name = "buttonKunden";
            this.buttonKunden.Size = new System.Drawing.Size(234, 32);
            this.buttonKunden.TabIndex = 3;
            this.buttonKunden.Text = "Kunden";
            this.buttonKunden.Click += new System.EventHandler(this.buttonKunden_Click);
            // 
            // buttonAuftraege
            // 
            this.buttonAuftraege.Location = new System.Drawing.Point(3, 186);
            this.buttonAuftraege.Name = "buttonAuftraege";
            this.buttonAuftraege.Size = new System.Drawing.Size(234, 32);
            this.buttonAuftraege.TabIndex = 4;
            this.buttonAuftraege.Text = "Aufträge";
            this.buttonAuftraege.Click += new System.EventHandler(this.buttonAuftraege_Click);
            // 
            // buttonFotos
            // 
            this.buttonFotos.Location = new System.Drawing.Point(3, 222);
            this.buttonFotos.Name = "buttonFotos";
            this.buttonFotos.Size = new System.Drawing.Size(234, 32);
            this.buttonFotos.TabIndex = 5;
            this.buttonFotos.Text = "Fotos";
            this.buttonFotos.Click += new System.EventHandler(this.buttonFotos_Click);
            // 
            // buttonAufgaben
            // 
            this.buttonAufgaben.Location = new System.Drawing.Point(3, 6);
            this.buttonAufgaben.Name = "buttonAufgaben";
            this.buttonAufgaben.Size = new System.Drawing.Size(234, 32);
            this.buttonAufgaben.TabIndex = 6;
            this.buttonAufgaben.Text = "Aufgaben";
            this.buttonAufgaben.Click += new System.EventHandler(this.buttonAufgaben_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.buttonAufgaben);
            this.Controls.Add(this.buttonFotos);
            this.Controls.Add(this.buttonAuftraege);
            this.Controls.Add(this.buttonKunden);
            this.Controls.Add(this.buttonKontakte);
            this.Controls.Add(this.buttonTermine);
            this.Controls.Add(this.buttonNotizen);
            this.Menu = this.mainMenu1;
            this.Name = "Main";
            this.Text = "MIKI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNotizen;
        private System.Windows.Forms.Button buttonTermine;
        private System.Windows.Forms.Button buttonKontakte;
        private System.Windows.Forms.Button buttonKunden;
        private System.Windows.Forms.Button buttonAuftraege;
        private System.Windows.Forms.MenuItem menuItemShutApplication;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Button buttonFotos;
        private System.Windows.Forms.Button buttonAufgaben;
    }
}

