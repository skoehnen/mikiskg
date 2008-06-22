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
    public partial class Kontakt : Form
    {
        OutlookCommunication objOutlook;

        public Kontakt()
        {
            InitializeComponent();
            objOutlook = new OutlookCommunication();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            objOutlook.addContact(textBoxName.Text, textBoxFirstName.Text, textBoxPhone.Text, textBoxMail.Text);
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }
    }
}