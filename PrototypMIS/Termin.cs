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
        Appointment termin;
        System.Collections.ArrayList linkedItems = null;

        public Termin()
        {
            InitializeComponent();
            outlookCom = new OutlookCommunication();
            this.menuItemLink.Enabled = false;
            this.textBoxEndTime.Text = "00:00";
            this.textBoxStartTime.Text = "00:00";
        }

        public Termin(ItemId id)
        {
            this.outlookCom = new OutlookCommunication();
            InitializeComponent();
            this.termin = new Appointment(id);
            this.dateTimePickerStartDate.Value = termin.Start;
            this.dateTimePickerEndDate.Value = termin.End;
            this.textBoxTitle.Text = termin.Subject;
            this.textBoxLocation.Text = termin.Location;
            this.textBoxStartTime.Text = MikiConverter.zeitAusDateTime(termin.Start);
            this.textBoxEndTime.Text = MikiConverter.zeitAusDateTime(termin.End);
            this.menuItemLink.Enabled = true;
            linkedItems = new DB_Verarbeitung().abfrage(id);
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            new Termine().Show();
            Dispose();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            this.outlookCom.addAppointment(textBoxTitle.Text, textBoxLocation.Text, textBoxStartTime.Text, dateTimePickerStartDate.Value, textBoxEndTime.Text, dateTimePickerEndDate.Value);
            new Termine().Show();
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(this.termin.ItemId).Show();
        }

    }
}