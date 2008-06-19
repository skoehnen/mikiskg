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
    public partial class Aufgabe : Form
    {
        OutlookCommunication myCommunication;

        public Aufgabe()
        {
            InitializeComponent();
            myCommunication = new OutlookCommunication();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            myCommunication.addTask(textBoxTitle.Text, dateTimePicker1.Value, textBoxDescription.Text);
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            myCommunication.deleteTask();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

                
    }
}