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
        
        public Termine()
        {
            InitializeComponent();
            DataTable table = new DataTable("Termine");
            DataColumn column = new DataColumn();
            DataRow row ;
            // Subject,Location,Start,End
            AppointmentCollection appointments = new OutlookCommunication().getOutlookSession().Appointments.Items;
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
            if (secureDelete.boolDelete())
            {
                int index = dataGridAppointments.CurrentRowIndex;
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
            Dispose();
            new Termin(MikiConverter.objectToItemId(oid)).Show();
            
        }

        private void dataGridAppointments_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        
    }
}