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
            foreach (PimItem item in collection)
            {
                row = table.NewRow();
                row["Titel"] = item.Properties[TaskProperty.Subject];
                row["Subject"] = item.Properties[TaskProperty.Body];
                row["Datum"] = item.Properties[TaskProperty.DueDate];
                table.Rows.Add(row);
            }
            dataGridAufgaben.DataSource = table;
            dataGridAufgaben.Update();
        }

        

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemAufgabeAnlegen_Click(object sender, EventArgs e)
        {
            new Aufgabe().Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridAufgaben.CurrentRowIndex;
            OutlookCommunication outlookCom=new OutlookCommunication();
            object Id = dataGridAufgaben[index, 21]; // weil in Spalte 21 die ID des Tasks steht
            outlookCom.deleteTask(MikiConverter.objectToItemId(Id));
        }

        private void menuItemShowEntry_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridAufgaben.CurrentRowIndex;
            int columnIndex = 21;
            object oid = dataGridAufgaben[rowIndex, columnIndex];
            new Aufgabe(MikiConverter.objectToItemId(oid)).Show();
        }
    }
}