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
    public partial class Suchen : Form
    {
        ItemId sourceItem;

        public Suchen()
        {
            InitializeComponent();
        }

        public Suchen(ItemId sourceItem)
        {
            InitializeComponent();
            this.sourceItem = sourceItem;

        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            new SuchErgebnis(kontaktSuche(textBoxSuchen.Text)).Show();
        }

        private ContactCollection kontaktSuche(string name)
        {
            return new OutlookCommunication().getOutlookSession().Contacts.Items.Restrict("[LastName]=\"" + name + "\"");  
            
        }

    }
}