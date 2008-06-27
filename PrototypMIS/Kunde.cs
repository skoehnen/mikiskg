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
        string anrede,vorname,nachname,strasse,hausnr,plz,kdnr;
        DataTable customertable;
        public Kunde()
        {
            InitializeComponent();
        }

        

        public Kunde(DataSet ukunde)
        {
            
            customertable = ukunde.Tables[0];
            foreach (DataRow dataRow in customertable.Rows)
            {
                anrede = (dataRow["NATITL"].ToString());
                vorname = (dataRow["NANAM2"].ToString());
                nachname = (dataRow["NANAM1"].ToString());
                hausnr = (dataRow["ANHAUS"].ToString());
                strasse = (dataRow["ANSTRA"].ToString());
                plz = (dataRow["ANPLZS"].ToString());
                kdnr = (dataRow["ERREFN"].ToString());
            }
            InitializeComponent();
            textBox_anrede.Text = anrede;
            textBox_vorname.Text = vorname;
            textBox_nachname.Text =  nachname;
            textBox_straße.Text =strasse;
            textBox_hausnr.Text = hausnr;
            textBox_plz.Text = plz;
            textBox_knr.Text = kdnr;
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }       
    }
}