using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;

namespace PrototypMIS
{
    public partial class Notiz : Form
    {
        NotizInfo notiz;
        DB_Verarbeitung  db = null;

        public Notiz()
        {
            InitializeComponent();
            db = new DB_Verarbeitung();
            
        }

        public Notiz(NotizInfo notiz)
        {
            InitializeComponent();
            this.notiz = notiz;
            db = new DB_Verarbeitung();

            textBoxText.Text = this.notiz.getText();
            textBoxTitel.Text = this.notiz.getTitel();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            fensterSchliessen();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (notiz == null)
            {
                db.notizSpeichern(new NotizInfo(textBoxTitel.Text, textBoxText.Text));
            }
            else
            {
                db.notizUpdateTitel(this.notiz.getTitel(),new NotizInfo(textBoxTitel.Text,textBoxText.Text));
            }
            this.fensterSchliessen();
        }

        private void fensterSchliessen()
        {
            Dispose();
            this.Close();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (this.notiz == null)
            {
                MessageBox.Show("Notiz nicht gespeichert");
            }
            else
            {
                db.notizLoeschenTitel(notiz.getTitel());
            }
            Dispose();
        }
    }
}