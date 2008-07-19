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

        public Notiz()
        {
            InitializeComponent();
            this.db = new DB_Verarbeitung();
            
        }

        public Notiz(NotizInfo notiz)
        {
            InitializeComponent();
            this.notiz = notiz;
            this.db = new DB_Verarbeitung();

            this.textBoxText.Text = this.notiz.getText();
            this.textBoxTitel.Text = this.notiz.getTitel();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            this.fensterSchliessen();
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
                    this.db.notizLoeschenTitel(notiz.getTitel());
                }
            }
            Dispose();
        }

        /// <summary>
        /// Verlinkung zu Objekt löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuItemDelete_Click(object sender, EventArgs e)
        {
            int row = this.dataGridLinks.CurrentCell.RowNumber;
            ItemId ziel = MikiConverter.objectToItemId(this.dataGridLinks[row, 2]);
            new DB_Verarbeitung().einzelverknuepfung_loeschen(this.notiz.getId(), MikiConverter.itemIdToInt(ziel), true);
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
    }
}