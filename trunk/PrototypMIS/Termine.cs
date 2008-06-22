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

        private void Termine_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        
    }
}