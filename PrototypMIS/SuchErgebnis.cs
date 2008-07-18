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
        ItemId source;

             
        public SuchErgebnis(DataTable table)
        {
            InitializeComponent();
            dataGridSearchResults.DataSource = table;
            dataGridSearchResults.Update();
        }

        public SuchErgebnis(DataTable table, ItemId source)
        {
            InitializeComponent();
            
            this.source = source;
            dataGridSearchResults.DataSource = table;
            dataGridSearchResults.Update();
        }
       
        private void menuItemBack_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            DB_Verarbeitung db = new DB_Verarbeitung();
            int rowIndex = dataGridSearchResults.CurrentRowIndex;
            int columnIndex = 0;
            Object oid = dataGridSearchResults[rowIndex,columnIndex];
            ItemId id = MikiConverter.objectToItemId(oid);
            db.verknuepfung_eintragen(source, id);
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            ItemId selectedID = MikiConverter.objectToItemId(dataGridSearchResults[dataGridSearchResults.CurrentRowIndex, 0]);
            String type = dataGridSearchResults[dataGridSearchResults.CurrentRowIndex, 3].ToString();
            if (type == "Microsoft.WindowsMobile.PocketOutlook.Contact")
            {
                new Kontakt(selectedID).Show();
            }
            else if (type == "Microsoft.WindowsMobile.PocketOutlook.Appointment")
            {
                new Termin(selectedID).Show();
            }
            else if (type == "Microsoft.WindowsMobile.PocketOutlook.Task")
            {
                new Aufgabe(selectedID).Show();
            }
            
        }

        
    }
}