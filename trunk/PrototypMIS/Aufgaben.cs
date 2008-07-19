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
    public partial class Aufgaben : Form
    {
        public Aufgaben()
        {
            InitializeComponent();
            TaskCollection collection;
            collection = new OutlookCommunication().getOutlookSession().Tasks.Items;
            DataTable table = new DataTable("Aufgaben");
            DataColumn column = new DataColumn();
            DataRow row;
            column.ColumnName = "Titel";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            column = new DataColumn();
            column.ColumnName = "Subject";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            column = new DataColumn();
            column.ColumnName = "Datum";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ItemId";
            table.Columns.Add(column);

            foreach (PimItem item in collection)
            {
                row = table.NewRow();
                row["Titel"] = item.Properties[TaskProperty.Subject];
                row["Subject"] = item.Properties[TaskProperty.Body];
                row["Datum"] = item.Properties[TaskProperty.DueDate];
                row["ItemId"] = item.ItemId.ToString();
                table.Rows.Add(row);
            }
            dataGridAufgaben.DataSource = table;

            // Create new Table Style
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "Aufgaben";
            dataGridAufgaben.TableStyles.Clear();
            dataGridAufgaben.TableStyles.Add(ts);
            dataGridAufgaben.TableStyles["Aufgaben"].GridColumnStyles["Titel"].Width = 80;
            dataGridAufgaben.TableStyles["Aufgaben"].GridColumnStyles["Subject"].Width = 80;
            dataGridAufgaben.TableStyles["Aufgaben"].GridColumnStyles["Datum"].Width = 50;
            
            dataGridAufgaben.Update();
        }

        

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemAufgabeAnlegen_Click(object sender, EventArgs e)
        {
            new Aufgabe().Show();
            this.Close();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            // Sicherheitsabfrage:
            if (secureDelete.boolDelete())
            {
                // Löschen:
                int index = dataGridAufgaben.CurrentRowIndex;
                OutlookCommunication outlookCom = new OutlookCommunication();
                object Id = dataGridAufgaben[index, 3]; // weil in Spalte 3 die ID des Tasks steht
                outlookCom.deleteTask(MikiConverter.objectToItemId(Id));
                Dispose();
                new Aufgaben().Show();
            }
        }

        private void menuItemShowEntry_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridAufgaben.CurrentRowIndex;
            int columnIndex = 3;
            object oid = dataGridAufgaben[rowIndex, columnIndex];
            this.Dispose();
            new Aufgabe(MikiConverter.objectToItemId(oid)).Show();
        }
    }
}