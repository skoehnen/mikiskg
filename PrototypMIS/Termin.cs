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
        Appointment termin = null;
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
            if (this.termin == null)
            {
                this.outlookCom.addAppointment(textBoxTitle.Text, textBoxLocation.Text, textBoxStartTime.Text, dateTimePickerStartDate.Value, textBoxEndTime.Text, dateTimePickerEndDate.Value);
            }
            else
            {
                this.termin.Subject = this.textBoxTitle.Text;
                this.termin.Start = this.outlookCom.datumZusammenbasteln(this.textBoxStartTime.Text, this.dateTimePickerStartDate.Value);
                this.termin.End = this.outlookCom.datumZusammenbasteln(this.textBoxEndTime.Text, this.dateTimePickerEndDate.Value);
                this.termin.Location = this.textBoxLocation.Text;
                this.termin.Update();

            }
            new Termine().Show();
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(this.termin.ItemId).Show();
        }

        /// <summary>
        /// Detail-Ansicht der verlinkten Items öffnen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuItemShow_Click(object sender, EventArgs e)
        {
            int column = this.dataGridLinks.CurrentCell.ColumnNumber;
            int row = this.dataGridLinks.CurrentCell.RowNumber;
            String typ = this.dataGridLinks[row, 1].ToString();
            if (typ == "Foto" && typ == "Notiz")
            {
                //hier kommt der Kram für die nicht POOM-Objekte rein
            }
            else
            {
                ItemId id = MikiConverter.objectToItemId(this.dataGridLinks[row, 2]);
                switch (typ)
                {
                    case "Task":
                        new Aufgabe(id).Show();
                        break;
                    case "Kontakt":
                        new Kontakt(id).Show();
                        break;
                    case "Termin":
                        new Termin(id).Show();
                        break;
                }
            }
        }

        /// <summary>
        /// Verlinkung zu Objekt löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuDelete_Click(object sender, EventArgs e)
        {
            int row = this.dataGridLinks.CurrentCell.RowNumber;
            ItemId ziel = MikiConverter.objectToItemId(this.dataGridLinks[row, 2]);
            new DB_Verarbeitung().einzelverknuepfung_loeschen(this.kontakt.ItemId, ziel);
        }
    }
}