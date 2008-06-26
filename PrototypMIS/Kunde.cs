using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PrototypMIS
{
    public partial class Kunde : Form
    {

        
        
        public Kunde()
        {
            InitializeComponent();
        }

        public Kunde(string auswahl)
        {
            DataSet kunde;
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            this.kunde = webkunde.getCustomerByRef(auswahl);
            //textBox_anrede.Text = kunde.
        }

        public Kunde(DataSet ukunde)
        {
            DataSet kunde;
            this.kunde = ukunde;
            
            InitializeComponent();
            
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        
    }
}