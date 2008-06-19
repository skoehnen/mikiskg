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

        
    }
}