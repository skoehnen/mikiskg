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
        Task task;
        
        public Aufgabe()
        {
            InitializeComponent();
            myCommunication = new OutlookCommunication();
        }

        public Aufgabe(ItemId ID)
        {
            InitializeComponent();
            task = new Task(ID);
            textBoxTitle.Text = task.Subject;
            dateTimePicker1.Value = task.DueDate;
            textBoxDescription.Text = task.Body;
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

        }

                
    }
}