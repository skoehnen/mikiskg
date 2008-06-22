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
        TaskCollection collection;
        ItemId source;

        public SuchErgebnis(TaskCollection collection)
        {
            InitializeComponent();
            this.collection = collection;
            dataGridSearchResults.DataSource = collection;
            dataGridSearchResults.Update();
        }

        public SuchErgebnis(TaskCollection collection, ItemId source)
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
            DB_Verarbeitung db = new DB_Verarbeitung();
            int rowIndex = dataGridSearchResults.CurrentRowIndex;
            int columnIndex = 21;
            Object oid = dataGridSearchResults[rowIndex,columnIndex];
            ItemId id = MikiConverter.objectToItemId(oid);
            db.verknuepfung_eintragen(source, id);
        }
    }
}