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
    public partial class Termin : Form
    {
        OutlookCommunication outlookCom;

        public Termin()
        {
            InitializeComponent();
            outlookCom = new OutlookCommunication();
        }

        public Termin(ItemId id)
        {
            outlookCom = new OutlookCommunication();
            InitializeComponent();
            Appointment termin = new Appointment(id);
            dateTimePickerStartDate.Value = termin.Start;
            dateTimePickerEndDate.Value = termin.End;
            textBoxTitle.Text = termin.Subject;
            textBoxLocation.Text = termin.Location;
            textBoxStartTime.Text = MikiConverter.zeitAusDateTime(termin.Start);
            textBoxEndTime.Text = MikiConverter.zeitAusDateTime(termin.End);
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