using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Forms;
using OpenNETCF.WindowsMobile.Ink.Interfaces;

namespace PrototypMIS
{
    public partial class Notiz : Form
    {
        public Notiz()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}