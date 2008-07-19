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
            linkedItems = new DB_Verarbeitung().abfrage(id);
            this.menuItemLink.Enabled = true;
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
            new Kontakte().Show();
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
            new Kontakte().Show();
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

            new Suchen(this.kontakt.ItemId).Show();
        }
    }
}