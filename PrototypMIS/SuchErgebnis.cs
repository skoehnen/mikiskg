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
    public partial class SuchErgebnis : Form
    {
        ContactCollection collection;
        ItemId source;

        public SuchErgebnis(ContactCollection collection)
        {
            InitializeComponent();
            this.collection = collection;
            dataGridSearchResults.DataSource = collection;
            dataGridSearchResults.Update();
        }

        public SuchErgebnis(ContactCollection collection, ItemId source)
        {
            InitializeComponent();
            this.collection = collection;
            this.source = source;
            dataGridSearchResults.DataSource = collection;
            dataGridSearchResults.Update();
        }

        
        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridSearchResults.CurrentRowIndex;
            // Konvertierungsproblem: kann nicht nach ItemId konvertieren!!!
            //ItemId target = (ItemId) dataGridSearchResults[rowIndex, dataGridSearchResults.VisibleColumnCount-1];
            DB_Verarbeitung db = new DB_Verarbeitung();
            db.verknuepfung_eintragen(source, target);
        }
    }
}