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
        TaskCollection collection;
        DataTable table;
        DataColumn column;
        DataRow row;

        public Aufgaben()
        {
            InitializeComponent();
            
            collection = new OutlookCommunication().getOutlookSession().Tasks.Items;
            table = new DataTable("Aufgaben");
            column = new DataColumn();

            this.createColumns();

            this.fillDataGrid();

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
            this.Close();
            this.Dispose();
        }

        private void menuItemAufgabeAnlegen_Click(object sender, EventArgs e)
        {
            new Aufgabe().Show();
            
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
            
            new Aufgabe(MikiConverter.objectToItemId(oid)).Show();
        }

        private void createColumns()
        {
            column = new DataColumn();

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

        }

        private void fillDataGrid()
        {
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
        }
    }
}