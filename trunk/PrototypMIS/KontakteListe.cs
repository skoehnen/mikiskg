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
    public partial class KontakteListe : Form
    {
        OutlookCommunication oc = null;
        ContactCollection collection = null;

        public KontakteListe()
        {
            this.oc = new OutlookCommunication();
            InitializeComponent();
            this.update();
        }

        private void update()
        {
            this.collection = this.oc.getOutlookSession().Contacts.Items;

            // ListView leeren
            this.listView1.Clear();

            // Spalten erzeugen
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            this.listView1.Columns.Add("Name", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Vorname", -2, HorizontalAlignment.Left);

            // Items erzeugen
            foreach (Contact kontakt in this.collection)
            {
                ListViewItem item = new ListViewItem(kontakt.FirstName);
                item.SubItems.Add(kontakt.LastName);
                item.Tag = new MikiDuo(MikiConverter.itemIdToInt(kontakt.ItemId), Konstanten.kontakt);
                this.listView1.Items.Add(item);
            }
        }

        private void menuItemContactCreate_Click(object sender, EventArgs e)
        {
            this.Close();
            new Kontakt().Show();
            this.Dispose();
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void contextMenuItemShow_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listView1.SelectedIndices[0];
            ListViewItem item = this.listView1.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo)item.Tag;
            this.Close();
            new Kontakt(new ItemId(auswahl.id)).Show();
            this.Dispose();
        }

        private void contextMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                // Löschen:
                int itemIndex = this.listView1.SelectedIndices[0];
                ListViewItem item = this.listView1.Items[itemIndex];
                MikiDuo auswahl = (MikiDuo)item.Tag;
                oc.deleteTask(MikiConverter.objectToItemId(auswahl.id));
                this.update();
            }
        }

        private void menuItemLinkToItem_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listView1.SelectedIndices[0];
            ListViewItem item = this.listView1.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo)item.Tag;
            new Suchen(auswahl.id, Konstanten.kontakt).Show();
            this.Dispose();
        }
    }
}