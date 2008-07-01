using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;
using OpenNETCF.WindowsMobile.Ink.Interfaces;

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
            db.notizSpeichern(new NotizInfo(textBoxTitel.Text, textBoxText.Text));
            fensterSchliessen();
        }

        private void fensterSchliessen()
        {
            Dispose();
            this.Close();
        }
    }
}