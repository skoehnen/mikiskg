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
        private void contextMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                int row = this.dataGridLinks.CurrentCell.RowNumber;
                ItemId ziel = MikiConverter.objectToItemId(this.dataGridLinks[row, 2]);
                new DB_Verarbeitung().einzelverknuepfung_loeschen(this.foto.getId(), MikiConverter.itemIdToInt(ziel), true);
            }
        }
    }
}