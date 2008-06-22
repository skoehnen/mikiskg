﻿using System;
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
    public partial class Aufgaben : Form
    {
        public Aufgaben()
        {
            InitializeComponent();
            TaskCollection collection;
            collection = new OutlookCommunication().getOutlookSession().Tasks.Items;
            dataGridAufgaben.DataSource = collection;
            dataGridAufgaben.Update();
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemAufgabeAnlegen_Click(object sender, EventArgs e)
        {
            new Aufgabe().Show();
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridAufgaben.CurrentRowIndex;
            OutlookCommunication outlookCom=new OutlookCommunication();
            object Id = dataGridAufgaben[index, 21]; // weil in Spalte 21 die ID des Tasks steht
            outlookCom.deleteTask(MikiConverter.objectToItemId(Id));
        }
    }
}