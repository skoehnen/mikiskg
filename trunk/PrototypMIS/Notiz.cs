using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;
using Microsoft.WindowsMobile.PocketOutlook;

namespace PrototypMIS
{
    public partial class Notiz : Form
    {
        NotizInfo notiz;
        DB_Verarbeitung  db = null;
        System.Collections.ArrayList linkedItems = null;

        public Notiz()
        {
            InitializeComponent();
            this.db = new DB_Verarbeitung();
            this.menuItemLink.Enabled = false;
            
        }

        public Notiz(NotizInfo notiz)
        {
            InitializeComponent();
            this.notiz = notiz;
            this.db = new DB_Verarbeitung();
            this.menuItemLink.Enabled = true;

            this.textBoxText.Text = this.notiz.getText();
            this.textBoxTitel.Text = this.notiz.getTitel();

            this.linkedItems = new DB_Verarbeitung().abfrage(this.notiz.getId());
            this.dataGridLinks.DataSource = this.linkedItems;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.fensterSchliessen();
            new NotizenListe().Show();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (notiz == null)
            {
                this.db.notizSpeichern(new NotizInfo(textBoxTitel.Text, textBoxText.Text));
            }
            else
            {
                this.db.notizUpdateTitel(this.notiz.getTitel(),new NotizInfo(textBoxTitel.Text,textBoxText.Text));
            }
            this.fensterSchliessen();
            new NotizenListe().Show();
        }

        private void fensterSchliessen()
        {
            Dispose();
            this.Close();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (this.notiz == null)
            {
                MessageBox.Show("Notiz nicht gespeichert");
            }
            else
            {
                if (secureDelete.boolDelete())
                {
                    new DB_Verarbeitung().gesamtverknuepfung_loeschen(notiz.getId(), Konstanten.notiz);
                    this.db.notizLoeschenTitel(notiz.getTitel());
                    Dispose();
                    new NotizenListe().Show();
                }
            }
        }

        /// <summary>
        /// Verlinkung zu Objekt löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {   int row = this.dataGridLinks.CurrentCell.RowNumber;
                int ziel = Convert.ToInt32(this.dataGridLinks[row, 2].ToString());
                int zielTyp = MikiConverter.stringToMikiObjectTyp(this.dataGridLinks[row, 1].ToString());
                new DB_Verarbeitung().einzelverknuepfung_loeschen(this.notiz.getId(), ziel, Konstanten.notiz, zielTyp);
                Dispose();
                new Notiz(this.notiz).Show();
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
        /// Callback-Handler der zum Linken verwendet wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(this.notiz.getId(), Konstanten.notiz).Show();
        }

        private void Notiz_GotFocus(object sender, EventArgs e)
        {
            if (this.notiz != null)
            {
                this.menuItemLink.Enabled = true;
                linkedItems = new DB_Verarbeitung().abfrage(this.notiz.getId());
                dataGridLinks.DataSource = linkedItems;
                dataGridLinks.Refresh();
            }
        }       
    }    
}
