﻿using System;
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
    public partial class Kontakt : Form
    {
        OutlookCommunication objOutlook = null;
        Contact kontakt = null;
        System.Collections.ArrayList linkedItems = null;

        public Kontakt()
        {
            InitializeComponent();
            objOutlook = new OutlookCommunication();
            this.menuItemLink.Enabled = false;
        }

        public Kontakt(ItemId id)
        {
            objOutlook = new OutlookCommunication();
            InitializeComponent();
            objOutlook = new OutlookCommunication();
            this.kontakt = new Contact(id);
            this.textBoxFirstName.Text = kontakt.FirstName;
            this.textBoxMail.Text = kontakt.Email1Address;
            this.textBoxName.Text = kontakt.LastName;
            this.textBoxPhone.Text = kontakt.HomeTelephoneNumber;
            linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(id));
            this.menuItemLink.Enabled = true;
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
            new KontakteListe().Show();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (this.kontakt == null)
            {
                objOutlook.addContact(textBoxName.Text, textBoxFirstName.Text, textBoxPhone.Text, textBoxMail.Text);
            }
            else
            {
                this.kontakt.FirstName = this.textBoxFirstName.Text;
                this.kontakt.LastName = this.textBoxName.Text;
                this.kontakt.HomeTelephoneNumber = this.textBoxPhone.Text;
                this.kontakt.Email1Address = this.textBoxMail.Text;
                this.kontakt.Update();
            }
            Dispose();
            new KontakteListe().Show();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            if (kontakt == null)
            {
                objOutlook.addContact(textBoxName.Text, textBoxFirstName.Text, textBoxPhone.Text, textBoxMail.Text);
            }
            //Hier noch Funktionalität einbauen damit die Verlinkung bei einem nicht gespeicherten Objekt die Speicherung auslöst
            //und man direkt die ItemId in this.kontakt.ItemId speichert.
            //
            //Bis dahin wird der Menü-Punkt ausgegraut

            new Suchen(MikiConverter.itemIdToInt(this.kontakt.ItemId),Konstanten.kontakt).Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                OutlookCommunication oc = new OutlookCommunication();
                oc.deleteContact(this.kontakt.ItemId);
                
                Dispose();
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
                new DB_Verarbeitung().einzelverknuepfung_loeschen(MikiConverter.itemIdToInt(this.kontakt.ItemId), ziel, Konstanten.kontakt, zielTyp);
                Dispose();
                new Kontakt(this.kontakt.ItemId).Show();
            }
        }

        private void Kontakt_GotFocus(object sender, EventArgs e)
        {
            if (this.kontakt != null)
            {
                this.menuItemLink.Enabled = true;
                linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(this.kontakt.ItemId));
                dataGridLinks.DataSource = linkedItems;
                dataGridLinks.Refresh();
            }
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }    

    }
}
