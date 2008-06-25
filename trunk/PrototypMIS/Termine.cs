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
            AppointmentCollection appointments = new OutlookCommunication().getOutlookSession().Appointments.Items;
            dataGridAppointments.DataSource=appointments;
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
            OutlookCommunication outlookCom = new OutlookCommunication();
            object Id = dataGridAppointments[index, 23]; // weil in Spalte 23 die ID des Termins steht
            outlookCom.deleteAppointment(MikiConverter.objectToItemId(Id));
        }

        private void menuItemAnzeigen_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridAppointments.CurrentRowIndex;
            int columnIndex = 23;
            MessageBox.Show(columnIndex.ToString());
            object oid = dataGridAppointments[rowIndex, columnIndex];
            new Termin(MikiConverter.objectToItemId(oid)).Show();
        }

        
    }
}