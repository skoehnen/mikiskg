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
        String username;
        Boolean menue;
        public Kunde(String uname,Boolean combo)
        {
            DataSet kunde = new DataSet();
            this.username = uname;
            this.menue = combo;
            
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            if (combo == true)
                kunde = webkunde.getCustomerByName(uname);
            else
                kunde = webkunde.getCustomerByRef(uname);

            DataTableReader reader = kunde.Tables[0].CreateDataReader();
            do
            {
                if (!reader.HasRows)
                {
                    Console.WriteLine("Empty Rows");
                }
                else
                {
                    //MessageBox.Show(reader.r);
                    
                }
            } while (reader.NextResult());
            if (kunde != null)
            {
                
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