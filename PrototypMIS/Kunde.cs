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

        DataSet kunde;

        public Kunde(String uname,Boolean combo)
        {
            DataSet kunde = new DataSet();
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            if (combo == true)
                kunde = webkunde.getCustomerByName(uname);
            else
                kunde = webkunde.getCustomerByRef(uname);

            if (kunde != null)
            {
                textBox_anrede.Text = kunde.Tables[0].Columns[0].ToString();
            }

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