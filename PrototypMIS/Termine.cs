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
    public partial class Termine : Form
    {
        AppointmentCollection appointments;
        DataTable table;
        DataColumn column;
        DataRow row;

        public Termine()
        {
            InitializeComponent();
            table = new DataTable("Termine");
            column = new DataColumn();
            
            // appointments muss vor createColumns bekannt sein
            appointments = new OutlookCommunication().getOutlookSession().Appointments.Items;
                        
            // ausgelagerte Column erstellung
            this.createColumns();

           // hier wurden die Inhalte von fillDataGrid() exportiert
            this.fillDataGrid();

            // Create new Table Style
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = "Termine";
            dataGridAppointments.TableStyles.Clear();
            dataGridAppointments.TableStyles.Add(ts);
            dataGridAppointments.TableStyles["Termine"].GridColumnStyles["Subject"].Width = 80;
            dataGridAppointments.TableStyles["Termine"].GridColumnStyles["Ort"].Width = 60;
            dataGridAppointments.TableStyles["Termine"].GridColumnStyles["Start"].Width = 50;
            dataGridAppointments.TableStyles["Termine"].GridColumnStyles["Ende"].Width = 50;

            dataGridAppointments.Update();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void menuItemTerminAnlegen_Click(object sender, EventArgs e)
        {
            new Termin().Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridAppointments.CurrentRowIndex;

            if (secureDelete.boolDelete())
            {
                OutlookCommunication outlookCom = new OutlookCommunication();
                //            object Id = dataGridAppointments[index, 23]; // weil in Spalte 23 die ID des Termins steht
                object Id = dataGrid_temp_Termine[index, 23]; // weil in Spalte 23 die ID des Termins steht
                outlookCom.deleteAppointment(MikiConverter.objectToItemId(Id));
                Dispose();
                new Termine().Show();
            }
        }

        private void menuItemAnzeigen_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridAppointments.CurrentRowIndex;
            int columnIndex = 23;
            //object oid = dataGridAppointments[rowIndex, columnIndex];
            object oid = dataGrid_temp_Termine[rowIndex, columnIndex];
            new Termin(MikiConverter.objectToItemId(oid)).Show();
            
        }

        private void dataGridAppointments_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void fillDataGrid()
        {
            foreach (PimItem item in appointments)
            {
                row = table.NewRow();
                row["Subject"] = item.Properties[AppointmentProperty.Subject];
                row["Ort"] = item.Properties[AppointmentProperty.Location];
                row["Start"] = item.Properties[AppointmentProperty.Start];
                row["Ende"] = item.Properties[AppointmentProperty.End];
                //row["ItemID"] = item.ItemId.ToString();
                table.Rows.Add(row);
            }

            dataGridAppointments.DataSource = table;//appointments;
        }

        private void createColumns()
        {
            column = new DataColumn();
            // Subject,Location,Start,End
            dataGrid_temp_Termine.DataSource = appointments;
            // Spalte 1
            column.ColumnName = "Subject";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            // Spalte 2
            column = new DataColumn();
            column.ColumnName = "Ort";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            // Spalte 3
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Start";
            table.Columns.Add(column);
            // Spalte 4
            column = new DataColumn();
            column.ColumnName = "Ende";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);
            // Spalte 5
            /*column = new DataColumn();
            column.ColumnName = "ItemID";
            column.DataType = System.Type.GetType("System.String");
            table.Columns.Add(column);*/
        }

        private void gotFocus(object sender, EventArgs e)
        {
            this.updateDataGrid();
        }

        private void updateDataGrid()
        {
            table = new DataTable("Termine");
            appointments = new OutlookCommunication().getOutlookSession().Appointments.Items;
            this.createColumns();
            this.fillDataGrid();
            dataGridAppointments.Update();
        }

        private void menuItemSuchen_Click(object sender, EventArgs e)
        {
            new Suchen();
        }

    }
}