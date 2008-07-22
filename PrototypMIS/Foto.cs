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
    public partial class Foto : Form
    {
        FotoInfo foto;
        bool neuesFoto;
        DB_Verarbeitung db = new DB_Verarbeitung();
        Fotos guiFotos = null;
        ListViewItem item = null;
        System.Collections.ArrayList linkedItems = null;

        public Foto(FotoInfo foto, bool neuesFoto, Fotos guiFotos, ListViewItem item)
        {
            InitializeComponent();
            this.foto = foto;
            this.neuesFoto = neuesFoto;
            pictureBox1.Image = new Bitmap(foto.getPfad());
            this.guiFotos = guiFotos;
            this.item = item;
            if (neuesFoto)
            {
                this.textBoxTitel.Text = "";
            }
            else
            {
                this.textBoxTitel.Text = foto.getTitel();
                this.textBoxBeschreibung.Text = foto.getBeschreibung();
                linkedItems = new DB_Verarbeitung().abfrage(foto.getId());
                dataGridLinks.DataSource = linkedItems;
            }
        }

        private void menuItemAbbrechen_Click(object sender, EventArgs e)
        {
            if (neuesFoto)
            {
                db.fotoLoeschen(foto);
            }
            this.Dispose();
            this.Close();
        }

        private void menuItemSpeichern_Click(object sender, EventArgs e)
        {
            this.guiFotos.titelAendern(this.foto.getTitel(),textBoxTitel.Text, item);
            foto.setBeschreibung(textBoxBeschreibung.Text);
            foto.setTitel(textBoxTitel.Text);
            db.fotoAendern(this.foto);
            this.Dispose();
            this.Close();
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

                case "Kunde":
                    new Kunde(new DB_Verarbeitung().kunde_suchen(this.dataGridLinks[row, 2].ToString(), false)).Show();
                    break;
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
            {
                int row = this.dataGridLinks.CurrentCell.RowNumber;
                int ziel = Convert.ToInt32(this.dataGridLinks[row, 2].ToString());
                int zielTyp = MikiConverter.stringToMikiObjectTyp(this.dataGridLinks[row, 1].ToString());
                new DB_Verarbeitung().einzelverknuepfung_loeschen(foto.getId(), ziel, Konstanten.aufgabe, zielTyp);
            }
        }    

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(this.foto.getId(), Konstanten.foto).Show();
        }

        private void Foto_GotFocus(object sender, EventArgs e)
        {
            if (!this.neuesFoto)
            {
                this.menuItemLink.Enabled = true;
                linkedItems = new DB_Verarbeitung().abfrage(this.foto.getId());
                dataGridLinks.DataSource = linkedItems;
                dataGridLinks.Refresh();
            }
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {

        }
    }
}