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
    public partial class NotizenListe : Form
    {
        DB_Verarbeitung db = new DB_Verarbeitung();

        public NotizenListe()
        {
            InitializeComponent();
            this.update();
        }

        private void NotizenListe_KeyDown(object sender, KeyEventArgs e)
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

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

        private void menuItemNewNote_Click(object sender, EventArgs e)
        {
            new Notiz().Show();
            this.Dispose();
        }

        private void menuItemShowSelectedItem_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listViewNotes.SelectedIndices[0];
            ListViewItem item = this.listViewNotes.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo)item.Tag;
            new Notiz(new NotizInfo(item.Text, item.Text)).Show();
            //new Notiz(new NotizInfo(item.Text, item.Text)).Show();
            this.Dispose();
        }

        private void menuItemDeleteSelectedItem_Click(object sender, EventArgs e)
        {
            // Sicherheitsabfrage:
            if (secureDelete.boolDelete())
            {
                // Löschen:
                int itemIndex = this.listViewNotes.SelectedIndices[0];
                ListViewItem item = this.listViewNotes.Items[itemIndex];
                MikiDuo auswahl = (MikiDuo)item.Tag;
                new DB_Verarbeitung().gesamtverknuepfung_loeschen(auswahl.id, Konstanten.notiz);
                db.notizLoeschenTitel(item.Text);
                this.update();
            }
        }

        private void menuItemLinkToItem_Click(object sender, EventArgs e)
        {
            int itemIndex = this.listViewNotes.SelectedIndices[0];
            ListViewItem item = this.listViewNotes.Items[itemIndex];
            MikiDuo auswahl = (MikiDuo)item.Tag;
            new Suchen(auswahl.id, Konstanten.notiz).Show();
            this.Dispose();
        }

        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void update()
        {                        
            // ListView leeren
            this.listViewNotes.Clear();

            // Spalten erzeugen
            this.listViewNotes.View = View.Details;
            this.listViewNotes.FullRowSelect = true;
            this.listViewNotes.Columns.Add("Titel", -2, HorizontalAlignment.Left);
            
            // Items erzeugen
            foreach (DataRow row in db.notizIdUndTitelAuslesen().Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(row["titel"].ToString());
                item.Tag = new MikiDuo((int) row["id"], Konstanten.notiz);
                this.listViewNotes.Items.Add(item);
            }
        }

        private void menuItemBack_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}