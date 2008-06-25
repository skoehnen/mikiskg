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
    public partial class Kunden : Form
    {
        public Kunden()
        {
            InitializeComponent();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void button_suche_Click(object sender, EventArgs e)
        {
            String kunde;
            Boolean combo = false;
            if (comboBox_Kundeneingabe.Text == "Kundennummer")
            {
                kunde = textBox_kundendaten.Text;
                combo = false;
            }
            else
            {
                kunde = textBox_kundendaten.Text;
                combo = true;
            }
            new Kunde(kunde,combo).Show();
        }

        private void comboBox_Kundeneingabe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_kundendaten_TextChanged(object sender, EventArgs e)
        {

        }

    }
}