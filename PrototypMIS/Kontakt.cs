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
        public Kontakt()
        {
            InitializeComponent();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}