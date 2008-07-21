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


        public Kunde(DataTable kundentabelle)
        {
            customertable = kundentabelle;
            foreach (DataRow dataRow in customertable.Rows)
            {
                anrede = (dataRow["Anrede"].ToString());
                vorname = (dataRow["Vorname"].ToString());
                nachname = (dataRow["Nachname"].ToString());
                hausnr = (dataRow["HausNr"].ToString());
                strasse = (dataRow["Straße"].ToString());
                plz = (dataRow["PLZ"].ToString());
                kdnr = (dataRow["Kref"].ToString());
            }
            InitializeComponent();
            textBox_anrede.Text = anrede;
            textBox_vorname.Text = vorname;
            textBox_nachname.Text = nachname;
            textBox_straße.Text = strasse;
            textBox_hausnr.Text = hausnr;
            textBox_plz.Text = plz;
            textBox_knr.Text = kdnr;

            DataTable auftrag_table = new DataTable("Auftragsnummer");
            DataColumn auftrag_column = new DataColumn();
            Referenz_Kunden.Service1 webauftrag = new PrototypMIS.Referenz_Kunden.Service1();
            DataSet auftrag_w = webauftrag.getAddsByCustomer(kdnr);
            int menge = auftrag_w.Tables[0].Rows.Count;

            auftrag_column.ColumnName = "Auftrag-Nr";
            auftrag_column.DataType = System.Type.GetType("System.Double");
            auftrag_table.Columns.Add(auftrag_column);

            DataRow row;
            foreach (DataRow dataRow2 in auftrag_w.Tables[0].Rows)
            {
                row = auftrag_table.NewRow();
                //auftragnummer[counter++] =  (double) dataRow2["AUATNR"];
                row["Auftrag-Nr"] = dataRow2["AUATNR"].ToString();
                auftrag_table.Rows.Add(row);
            }

            dataGrid_kundenauftraege.DataSource = auftrag_table;
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
            DB_Verarbeitung db = new DB_Verarbeitung();
            db.kunde_eintragen(anrede,kdnr,vorname,nachname,plz,strasse,hausnr);
            //AUATNR
            DataTable auftrag_table = new DataTable("Auftragsnummer");
            DataColumn auftrag_column = new DataColumn();
            Referenz_Kunden.Service1 webauftrag = new PrototypMIS.Referenz_Kunden.Service1();
            DataSet auftrag_w = webauftrag.getAddsByCustomer(kdnr);
            int menge = auftrag_w.Tables[0].Rows.Count;
            
            auftrag_column.ColumnName = "Auftrag-Nr";
            auftrag_column.DataType = System.Type.GetType("System.Double");
            auftrag_table.Columns.Add(auftrag_column);
            
            DataRow row ;
            foreach (DataRow dataRow2 in auftrag_w.Tables[0].Rows)
            {
                row = auftrag_table.NewRow();
                //auftragnummer[counter++] =  (double) dataRow2["AUATNR"];
                row["Auftrag-Nr"] = dataRow2["AUATNR"].ToString();
                auftrag_table.Rows.Add(row);
            }

            dataGrid_kundenauftraege.DataSource =  auftrag_table;
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

        private void dataGrid_kundenauftraege_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }       
    }
}