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
            int rowIndex = this.dataGrid1.CurrentCell.ColumnNumber;
            int columnIndex = this.dataGrid1.CurrentCell.ColumnNumber;
            new Notiz(this.db.notizHolenTitel(this.dataGrid1[rowIndex,columnIndex].ToString())).Show();
        }

        private void gotFocus(object sender, EventArgs e)
        {
            this.updateGrid();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            this.db.notizLoeschenTitel(this.dataGrid1[dataGrid1.CurrentCell.RowNumber, this.dataGrid1.CurrentCell.ColumnNumber].ToString());
            this.updateGrid();
        }

        private void updateGrid()
        {
            this.dataGrid1.DataSource = this.db.notizListe().Tables[0];
        }
    }
}