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
    public partial class Termin : Form
    {
        OutlookCommunication outlookCom;

        public Termin()
        {
            InitializeComponent();
            outlookCom = new OutlookCommunication();
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            outlookCom.addAppointment(textBoxTitle.Text, textBoxLocation.Text, textBoxStartTime.Text, dateTimePickerStartDate.Value, textBoxEndTime.Text, dateTimePickerEndDate.Value);
            Dispose();
            new Termin();
        }

    }
}