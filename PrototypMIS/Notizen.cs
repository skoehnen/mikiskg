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
    public partial class Notizen : Form
    {
        DB_Verarbeitung db = new DB_Verarbeitung();

        public Notizen()
        {
            InitializeComponent();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void menuItemCreateNote_Click(object sender, EventArgs e)
        {
            new Notiz().Show();
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGrid1.CurrentCell.ColumnNumber;
            int columnIndex = dataGrid1.CurrentCell.ColumnNumber;
            new Notiz(db.notizHolenTitel(dataGrid1[rowIndex,columnIndex].ToString())).Show();
        }

        private void gotFocus(object sender, EventArgs e)
        {
            this.updateGrid();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            db.notizLoeschenTitel(dataGrid1[dataGrid1.CurrentCell.RowNumber, dataGrid1.CurrentCell.ColumnNumber].ToString());
            updateGrid();
        }

        private void updateGrid()
        {

            dataGrid1.DataSource = db.notizIdUndTitelAuslesen().Tables[0];
            dataGrid1.Update();

           // dataGrid1.DataSource = db.notizListe().Tables[0];
        }

        private void menuItemSearch_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

    }
}