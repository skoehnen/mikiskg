using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace PrototypMIS
{
    
    public partial class Kunden : Form
    {
        string[] kundennr;
        DataTable kunde;
        DataSet ergebnis = new DataSet();
        Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();

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

            DB_Verarbeitung db = new DB_Verarbeitung();
//            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            if (comboBox_Kundeneingabe.Text == "Kundennummer")
            {
                kunde = db.kunde_suchen(textBox_kundendaten.Text, false);
                if (kunde == null)
                {
                    listBox_kunden.Visible = false;
                    button_uebernahme.Visible = false;
                    button_netzsuche.Visible = false;
                    ergebnis = webkunde.getCustomerByRef(textBox_kundendaten.Text);
                    new Kunde(ergebnis).Show();
                }
                else
                {
                    listBox_kunden.Visible = true;
                    button_uebernahme.Visible = true;
                    button_netzsuche.Visible = true;
                    listBox_kunden.Items.Clear();
                    int menge = kunde.Rows.Count, counter = 0;
                    kundennr = new string[menge];
                    foreach (DataRow dataRow in kunde.Rows)
                    {
                        listBox_kunden.Items.Add(dataRow["Nachname"] + ", " + dataRow["Vorname"] + ", " + dataRow["Straße"]);
                        kundennr[counter++] = dataRow["Kref"].ToString();
                        listBox_kunden.ValueMember = dataRow["Kref"].ToString();
                    }
                }
            }
            else
            {
                kunde = db.kunde_suchen(textBox_kundendaten.Text, true);
                if (kunde == null)
                {
                    ergebnis = webkunde.getCustomerByName(textBox_kundendaten.Text);
                    listBox_kunden.Visible = true;
                    listBox_kunden.Items.Clear();
                    button_uebernahme.Visible = true;
                    button_netzsuche.Visible = true;
                    DataTable dataTable = ergebnis.Tables[0];
                    int menge = dataTable.Rows.Count, counter = 0;
                    kundennr = new string[menge];
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        listBox_kunden.Items.Add(dataRow["NANAM1"] + ", " + dataRow["NANAM2"] + ", " + dataRow["ANSTRA"]);
                        kundennr[counter++] = dataRow["ERREFN"].ToString();
                        listBox_kunden.ValueMember = dataRow["ERREFN"].ToString();
                    }
                }
                else
                {
                    listBox_kunden.Visible = true;
                    button_uebernahme.Visible = true;
                    button_netzsuche.Visible = true;
                    listBox_kunden.Items.Clear();
                    int menge = kunde.Rows.Count, counter = 0;
                    kundennr = new string[menge];
                    foreach (DataRow dataRow in kunde.Rows)
                    {
                        listBox_kunden.Items.Add(dataRow["Nachname"] + ", " + dataRow["Vorname"] + ", " + dataRow["Straße"]);
                        kundennr[counter++] = dataRow["Kref"].ToString();
                        listBox_kunden.ValueMember = dataRow["Kref"].ToString();
                    }
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
            Referenz_Kunden.Service1 webkunde = new PrototypMIS.Referenz_Kunden.Service1();
            DataSet netzkunde = new DataSet();
            int auswahl;
            if (kunde == null)
            {
                
                auswahl = listBox_kunden.SelectedIndex;
                netzkunde = webkunde.getCustomerByRef(kundennr[auswahl].ToString());
                listBox_kunden.Items.Clear();
                new Kunde(netzkunde).Show();
            }
            else
            {
                auswahl = listBox_kunden.SelectedIndex;
                DB_Verarbeitung db = new DB_Verarbeitung();
                kunde = db.kunde_suchen(kundennr[auswahl],false);
                Dispose();
                new Kunde(kunde).Show();
            }
        }

        private void button_netzsuche_Click(object sender, EventArgs e)
        {
            kunde = null;
            if (comboBox_Kundeneingabe.Text == "Kundennummer")
                ergebnis = webkunde.getCustomerByRef(textBox_kundendaten.Text);
            else
                ergebnis = webkunde.getCustomerByName(textBox_kundendaten.Text);
            listBox_kunden.Visible = true;
            button_uebernahme.Visible = true;
            button_netzsuche.Visible = true;
            listBox_kunden.Items.Clear();
            DataTable dataTable = ergebnis.Tables[0];
            int menge = dataTable.Rows.Count, counter = 0;
            kundennr = new string[menge];
            foreach (DataRow dataRow in dataTable.Rows)
            {
                listBox_kunden.Items.Add(dataRow["NANAM1"] + ", " + dataRow["NANAM2"] + ", " + dataRow["ANSTRA"]);
                kundennr[counter++] = dataRow["ERREFN"].ToString();
                listBox_kunden.ValueMember = dataRow["ERREFN"].ToString();
            }
        }

        

    }
}