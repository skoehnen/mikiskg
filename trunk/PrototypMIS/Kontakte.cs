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
    public partial class Kontakte : Form
    {

        public Kontakte()
        {
            InitializeComponent();
            ContactCollection collection;
            collection = new OutlookCommunication().getOutlookSession().Contacts.Items;
            dataGridKontakte.DataSource = collection;
            dataGridKontakte.Update();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            new Kontakt().Show();
        }

        private void dataGridKontakte_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridKontakte.CurrentRowIndex;
            int columnIndex = 60;
            object oid = dataGridKontakte[rowIndex, columnIndex];
            new Kontakt(MikiConverter.objectToItemId(oid));
        }
    }
}