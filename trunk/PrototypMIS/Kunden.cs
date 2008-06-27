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
    public partial class Kunden : Form
    {
        public Kunden()
        {
            InitializeComponent();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void button_suche_Click(object sender, EventArgs e)
        {
            DataSet ergebnis = new DataSet();
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            if (comboBox_Kundeneingabe.Text == "Kundennummer")
            {
                ergebnis = webkunde.getCustomerByRef(textBox_kundendaten.Text);
                new Kunde(ergebnis).Show();
            }
            else
            {
                ergebnis = webkunde.getCustomerByName(textBox_kundendaten.Text);
                listBox_kunden.Visible = true;
                button_uebernahme.Visible = true;
                DataTable dataTable = ergebnis.Tables[0];
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    listBox_kunden.Items.Add(dataRow["NANAM1"] + ", " + dataRow["NANAM2"] + ", " + dataRow["ANSTRA"]);
                    listBox_kunden.ValueMember = dataRow["ERREFN"].ToString();
                }
            }
            
        }

        private void comboBox_Kundeneingabe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_kundendaten_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox_kunden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_uebernahme_Click(object sender, EventArgs e)
        {
            string auswahl;
            auswahl = (string)listBox_kunden.SelectedValue;
            new Kunde(auswahl).Show();
            
        }

    }
}