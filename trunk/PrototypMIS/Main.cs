﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrototypMIS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonAufgaben_Click(object sender, EventArgs e)
        {
            new Aufgaben().Show();
        }

        private void buttonNotizen_Click(object sender, EventArgs e)
        {
            new Notizen().Show();
        }

        private void buttonTermine_Click(object sender, EventArgs e)
        {
            new Termine().Show();
        }

        private void buttonKontakte_Click(object sender, EventArgs e)
        {
            new Kontakte().Show();
        }

        private void buttonKunden_Click(object sender, EventArgs e)
        {
            new Kunden().Show();
        }

        private void buttonFotos_Click(object sender, EventArgs e)
        {
            new Fotos().Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            new Suchen().Show();
        }

        private void menuItemShutApplication_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}