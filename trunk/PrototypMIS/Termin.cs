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
            linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(id));
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
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
            
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(MikiConverter.itemIdToInt(this.termin.ItemId),Konstanten.termin).Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                if (this.termin == null)
                {
                    MessageBox.Show("Dieser Eintrag existiert nicht!");
                }
                else
                {
                    this.termin.Delete();
                    Dispose();
                }
            }
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
            switch (typ)
                {
                    case "Aufgabe":
                        new Aufgabe(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Kontakt":
                        new Kontakt(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Termin":
                        new Termin(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Foto":
                        new Foto(new DB_Verarbeitung().fotoHolen(Convert.ToInt32(this.dataGridLinks[row, 2].ToString())), false, null, null).Show();
                        break;

                    case "Notiz":
                        new Notiz(new DB_Verarbeitung().notizHolen(Convert.ToInt32(this.dataGridLinks[row, 2].ToString()))).Show();
                        break;
            }
        }

        /// <summary>
        /// Verlinkung zu Objekt löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                int row = this.dataGridLinks.CurrentCell.RowNumber;
                int ziel = Convert.ToInt32(this.dataGridLinks[row, 2].ToString());
                int zielTyp = MikiConverter.stringToMikiObjectTyp(this.dataGridLinks[row, 1].ToString());
                new DB_Verarbeitung().einzelverknuepfung_loeschen(MikiConverter.itemIdToInt(this.termin.ItemId), ziel, Konstanten.aufgabe, zielTyp);
            }
        }

        private void Termin_GotFocus(object sender, EventArgs e)
        {
            if (this.termin != null)
            {
                this.menuItemLink.Enabled = true;
                linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(this.termin.ItemId));
                dataGridLinks.DataSource = linkedItems;
                dataGridLinks.Refresh();
            }
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new Suchen( MikiConverter.itemIdToInt(this.termin.ItemId), Konstanten.termin);
        }    
    }
}
