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
    public partial class TermineList : Form
    {
        OutlookCommunication oc = null;
        AppointmentCollection collection = null;

        public TermineList()
        {
            InitializeComponent();
            this.oc = new OutlookCommunication();
            this.update();
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

        private void menuItemNewAppointment_Click(object sender, EventArgs e)
        {
            new Termin().Show();
            this.Dispose();
        }

        private void menuItemShowListItem_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listViewTermine.SelectedIndices[0];
            ListViewItem item = this.listViewTermine.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo)item.Tag;
            this.Close();
            new Termin(new ItemId(auswahl.id)).Show();
            this.Dispose();
        }

        private void menuItemDeleteListItem_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                int itemIndex = this.listViewTermine.SelectedIndices[0];
                ListViewItem item = this.listViewTermine.Items[itemIndex];
                MikiDuo auswahl = (MikiDuo)item.Tag;
                new DB_Verarbeitung().gesamtverknuepfung_loeschen(auswahl.id, Konstanten.termin);
                this.oc.deleteAppointment(MikiConverter.objectToItemId(auswahl.id));
                this.update();
            }
        }

        private void update()
        {
            this.collection = this.oc.getOutlookSession().Appointments.Items;

            // ListView leeren
            this.listViewTermine.Clear();

            // Spalten erzeugen
            this.listViewTermine.View = View.Details;
            this.listViewTermine.FullRowSelect = true;
            this.listViewTermine.Columns.Add("Beschreibung", -2, HorizontalAlignment.Left);
            this.listViewTermine.Columns.Add("Beginnt", -2, HorizontalAlignment.Left);
            this.listViewTermine.Columns.Add("Endet", -2, HorizontalAlignment.Left);

            // Items erzeugen
            foreach (Appointment app in this.collection)
            {
                ListViewItem item = new ListViewItem(app.Subject);
                item.SubItems.Add(app.Start.Day + "." + app.Start.Month + "." + app.Start.Year);
                item.SubItems.Add(app.End.Day + "." + app.End.Month + "." + app.End.Year);
                item.Tag = new MikiDuo(MikiConverter.itemIdToInt(app.ItemId), Konstanten.termin);
                this.listViewTermine.Items.Add(item);
            }
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}