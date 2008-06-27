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
        DataSet kunde;
        DataTable customertable;
        public Kunde()
        {
            InitializeComponent();
        }

        public Kunde(string auswahl)
        {
            
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            this.kunde = webkunde.getCustomerByRef(auswahl);
            customertable = kunde.Tables[0];
            foreach (DataRow dataRow in customertable.Rows)
            {
                listBox1.Items.Add(dataRow["NATITL"]);
            }
            InitializeComponent();
        }

        public Kunde(DataSet ukunde)
        {
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