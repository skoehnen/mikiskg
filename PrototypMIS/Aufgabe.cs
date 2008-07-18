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
    public partial class Aufgabe : Form
    {
        OutlookCommunication myCommunication;
        Task task = null;
        System.Collections.ArrayList linkedItems = null;
        
        public Aufgabe()
        {
            InitializeComponent();
            myCommunication = new OutlookCommunication();
            this.menuItemLink.Enabled = false;
        }

        public Aufgabe(ItemId id)
        {
            InitializeComponent();
            task = new Task(id);
            textBoxTitle.Text = task.Subject;
            dateTimePicker1.Value = task.DueDate;
            textBoxDescription.Text = task.Body;
            this.menuItemLink.Enabled = true;
            linkedItems = new DB_Verarbeitung().abfrage(id);
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            myCommunication.addTask(textBoxTitle.Text, dateTimePicker1.Value, textBoxDescription.Text);
            this.Close();
            new Aufgaben().Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            OutlookCommunication outlookCom = new OutlookCommunication();
            outlookCom.deleteTask(task.ItemId);
            Dispose();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(task.ItemId).Show();
        }

                
    }
}