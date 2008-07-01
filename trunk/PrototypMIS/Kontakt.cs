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
        OutlookCommunication objOutlook;

        public Kontakt()
        {
            InitializeComponent();
            objOutlook = new OutlookCommunication();
        }

        public Kontakt(ItemId id)
        {
            InitializeComponent();
            Contact kontakt = new Contact(id);
            textBoxFirstName.Text = kontakt.FirstName;
            textBoxMail.Text = kontakt.Email1Address;
            textBoxName.Text = kontakt.LastName;
            textBoxPhone.Text = kontakt.HomeTelephoneNumber;
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
            new Kontakte().Show();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            objOutlook.addContact(textBoxName.Text, textBoxFirstName.Text, textBoxPhone.Text, textBoxMail.Text);
            Dispose();
            new Kontakte().Show();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }
    }
}