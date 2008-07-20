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
            myCommunication = new OutlookCommunication();
            InitializeComponent();
            task = new Task(id);
            textBoxTitle.Text = task.Subject;
            dateTimePicker1.Value = task.DueDate;
            textBoxDescription.Text = task.Body;
            this.menuItemLink.Enabled = true;
            linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(id));
            dataGridLinks.DataSource = linkedItems;
            dataGridLinks.Refresh();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (this.task == null)
            {
                myCommunication.addTask(textBoxTitle.Text, dateTimePicker1.Value, textBoxDescription.Text);
            }
            else
            {
                this.task.Subject = this.textBoxTitle.Text;
                this.task.DueDate = this.dateTimePicker1.Value;
                this.task.Body = this.textBoxDescription.Text;
                this.task.Update();
            }
            this.Close();
            new Aufgaben().Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                if (this.task == null)
                {
                    MessageBox.Show("Dieser Eintrag existiert nicht!");
                }
                else
                {
                    OutlookCommunication outlookCom = new OutlookCommunication();
                    outlookCom.deleteTask(task.ItemId);
                    Dispose();
                    new Aufgaben().Show();
                }
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemLink_Click(object sender, EventArgs e)
        {
            new Suchen(MikiConverter.itemIdToInt(task.ItemId),Konstanten.aufgabe).Show();
        }

        /// <summary>
        /// Detail-Ansicht der verlinkten Items öffnen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuItemShow_Click(object sender, EventArgs e)
        {
            int column = this.dataGridLinks.CurrentCell.ColumnNumber;
            int row = this.dataGridLinks.CurrentCell.RowNumber;
            String typ = this.dataGridLinks[row, 1].ToString();
                switch (typ)
                {
                    case "Aufgabe":
                        new Aufgabe(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Kontakt":
                        new Kontakt(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Termin":
                        new Termin(MikiConverter.objectToItemId(this.dataGridLinks[row, 2])).Show();
                        break;

                    case "Foto":
                        new Foto(new DB_Verarbeitung().fotoHolen(Convert.ToInt32(this.dataGridLinks[row, 2].ToString())), false, null, null).Show();
                        break;

                    case "Notiz":
                        new Notiz(new DB_Verarbeitung().notizHolen(Convert.ToInt32(this.dataGridLinks[row, 2].ToString()))).Show();
                        break;
                }
        }

        /// <summary>
        /// Verlinkung zu Objekt löschen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuItemDelete_Click(object sender, EventArgs e)
        {
            if (secureDelete.boolDelete())
            {
                int row = this.dataGridLinks.CurrentCell.RowNumber;
                int ziel = Convert.ToInt32(this.dataGridLinks[row, 2].ToString());
                int zielTyp = MikiConverter.stringToMikiObjectTyp(this.dataGridLinks[row,1].ToString());
                new DB_Verarbeitung().einzelverknuepfung_loeschen(MikiConverter.itemIdToInt(this.task.ItemId), ziel, Konstanten.aufgabe, zielTyp);
            }
        }

        private void Aufgabe_GotFocus(object sender, EventArgs e)
        {
            if (this.task != null)
            {
                this.menuItemLink.Enabled = true;
                linkedItems = new DB_Verarbeitung().abfrage(MikiConverter.itemIdToInt(task.ItemId));
                dataGridLinks.DataSource = linkedItems;
                dataGridLinks.Refresh();
            }
        }
    }
}