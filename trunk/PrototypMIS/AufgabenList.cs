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
    public partial class KontakteList : Form
    {
        OutlookCommunication oc = null;
        TaskCollection collection = null;

        public KontakteList()
        {
            InitializeComponent();
            this.oc = new OutlookCommunication();
            this.update();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            // Sicherheitsabfrage:
            if (secureDelete.boolDelete())
            {
                // Löschen:
                int itemIndex = this.listView1.SelectedIndices[0];
                ListViewItem item = this.listView1.Items[itemIndex];
                MikiDuo auswahl = (MikiDuo) item.Tag;
                oc.deleteTask(MikiConverter.objectToItemId(auswahl.id));
                this.update();
            }
        }

        private void menuItemShowEntry_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listView1.SelectedIndices[0];
            ListViewItem item = this.listView1.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo) item.Tag;
            this.Close();
            new Aufgabe(new ItemId(auswahl.id)).Show();
            this.Dispose();
        }

        private void update()
        {
            this.collection = this.oc.getOutlookSession().Tasks.Items;

            // ListView leeren
            this.listView1.Clear();

            // Spalten erzeugen
            this.listView1.View = View.Details;
            this.listView1.FullRowSelect = true;
            this.listView1.Columns.Add("Titel", -2, HorizontalAlignment.Left);
            this.listView1.Columns.Add("Fällig bis", -2, HorizontalAlignment.Left);

            // Items erzeugen
            foreach (Task task in this.collection)
            {
                ListViewItem item = new ListViewItem(task.Subject);
                item.SubItems.Add(task.DueDate.ToString());
                item.Tag = new MikiDuo(MikiConverter.itemIdToInt(task.ItemId), Konstanten.aufgabe);
                this.listView1.Items.Add(item);
            }
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void menuItemCreateTask_Click(object sender, EventArgs e)
        {            
            this.Close();
            new Aufgabe().Show();
            this.Dispose();
        }
    }
}