using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    public partial class Suchen : Form
    {
        ItemId sourceItem;
        DataTable table;
        DataColumn column;
        DataRow row;
        DB_Verarbeitung db;

        public Suchen()
        {
            InitializeComponent();
            table = new DataTable("Suchergebnis");
            this.createTable();
            db = new DB_Verarbeitung();
        }

        public Suchen(ItemId sourceItem)
        {
            InitializeComponent();
            this.sourceItem = sourceItem;
            table = new DataTable("Suchergebnis");
            this.createTable();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            PimItemCollection collection;
            table.Clear();            

            if (checkBoxKontakte.Checked)
            {
                collection = kontaktSuche(textBoxSuchen.Text);
                
                foreach(PimItem item in collection)
                {
                    row = table.NewRow();
                    row["ItemID"] = item.ItemId.ToString();
                    row["Titel/Nachname"] = item.Properties[ContactProperty.LastName];
                    row["Name/Datum"] = item.Properties[ContactProperty.FirstName];
                    row["Type"] = item.GetType();
                    table.Rows.Add(row);
                }
            }
            if (checkBoxAufgaben.Checked)
            {
                collection = aufgabenSuche(textBoxSuchen.Text);
               
                foreach (PimItem item in collection)
                {
                    row = table.NewRow();
                    row["ItemID"] = item.ItemId.ToString();
                    row["Titel/Nachname"] = item.Properties[TaskProperty.Subject];
                    row["Name/Datum"] = item.Properties[TaskProperty.DueDate.ToString()];
                    row["Type"] = item.GetType();
                    table.Rows.Add(row);
                }
            }
            if (checkBoxNotizen.Checked)
            {
                System.Data.DataSet data = db.notizSuche(textBoxSuchen.Text);
                row = table.NewRow();
                row["ItemID"] = data.Tables[0].Rows[0].ItemArray[1];
                row["Titel/Nachname"] = data.Tables[0].Rows[0].ItemArray[0];
            }
            if (checkBoxTermine.Checked)
            {
                collection = terminSuche(textBoxSuchen.Text);
               
                foreach (PimItem item in collection)
                {
                    row = table.NewRow();
                    row["ItemID"] = Convert.ToString(item.ItemId);
                    row["Titel/Nachname"] = item.Properties[AppointmentProperty.Subject];
                    row["Name/Datum"] = item.Properties[AppointmentProperty.Start.ToString()];
                    row["Type"] = item.GetType();
                    table.Rows.Add(row);
                }
            }
            //if (checkBoxKunden.Checked)
            //{
            //    // Kunde
            //}
            
            //if (checkBoxFotos.Checked)
            //{
            //    // Foto
            //}
            
            new SuchErgebnis(table).Show();
            
        }

        private TaskCollection aufgabenSuche(string name)
        {
            return new OutlookCommunication().getOutlookSession().Tasks.Items.Restrict("[Subject]=\"" + name + "\"");
            
        }

        private ContactCollection kontaktSuche(String name)
        {
            return new OutlookCommunication().getOutlookSession().Contacts.Items.Restrict("[LastName]=\"" + name + "\"");
        }

        private AppointmentCollection terminSuche(String name)
        {
            return new OutlookCommunication().getOutlookSession().Appointments.Items.Restrict("[Subject]=\"" + name + "\"");
        }

        /// <summary>
        /// CreateTable() formatiert die Ergebnistabelle
        /// </summary>
        private void createTable()
        {
            // 1. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ItemID";
            table.Columns.Add(column);

            // 2. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Titel/Nachname";
            table.Columns.Add(column);

            // 3. Spalte
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Name/Datum";
            table.Columns.Add(column);

            // 4. Spalte
            // benötigt um den Type mitzuübergeben
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Type");
            column.ColumnName = "Type";
            table.Columns.Add(column);
        }
        
    }
}