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
    public partial class Suchen : Form
    {
        int sourceItem;
        int typ = -1;
        DB_Verarbeitung db;

        public Suchen()
        {
            InitializeComponent();
            db = new DB_Verarbeitung();
        }

        public Suchen(int sourceItem, int typ)
        {
            InitializeComponent();
            this.sourceItem = sourceItem;
            db = new DB_Verarbeitung();
            this.typ = typ;
        }

        private void menuItemZurueck_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void buttonSuchen_Click(object sender, EventArgs e)
        {
            PimItemCollection collection;

            SuchergebnisTree ergebnis;

            if (this.sourceItem == -1)
            {
                ergebnis = new SuchergebnisTree();
            }
            else
            {
                ergebnis = new SuchergebnisTree(this.sourceItem, typ);
            }

            if (checkBoxKontakte.Checked)
            {
                collection = kontaktSuche(textBoxSuchen.Text);
                ergebnis.setFound(0,collection.Count);
                
                foreach(PimItem item in collection)
                {
                    ergebnis.addNewChield(0, new MikiTreeNode(MikiConverter.itemIdToInt(item.ItemId),item.Properties[ContactProperty.LastName] + ", " + item.Properties[ContactProperty.FirstName],Konstanten.kontakt));
                }
            }
            if (checkBoxAufgaben.Checked)
            {
                collection = aufgabenSuche(textBoxSuchen.Text);
                ergebnis.setFound(1, collection.Count);
  
                foreach (PimItem item in collection)
                {
                    ergebnis.addNewChield(1, new MikiTreeNode(MikiConverter.itemIdToInt(item.ItemId),item.Properties[TaskProperty.Subject].ToString(),Konstanten.aufgabe));
                }
            }
            if (checkBoxNotizen.Checked)
            {
                System.Data.DataSet data = db.notizSuchen(textBoxSuchen.Text);

                ergebnis.setFound(2, data.Tables[0].Rows.Count);

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    ergebnis.addNewChield(2, new MikiTreeNode((int)row["id"], row["titel"].ToString(), Konstanten.notiz));
                }
            }
            if (checkBoxTermine.Checked)
            {
                collection = terminSuche(textBoxSuchen.Text);
                ergebnis.setFound(3, collection.Count);
               
                foreach (PimItem item in collection)
                {
                    ergebnis.addNewChield(3, new MikiTreeNode(MikiConverter.itemIdToInt(item.ItemId),item.Properties[AppointmentProperty.Subject].ToString(),Konstanten.termin));
                }
            }
            if (this.checkBoxFotos.Checked)
            {
                System.Data.DataSet data = db.fotoSuchen(textBoxSuchen.Text);

                ergebnis.setFound(5, data.Tables[0].Rows.Count);

                foreach (DataRow row in data.Tables[0].Rows)
                {
                    ergebnis.addNewChield(5, new MikiTreeNode((int)row["id"], row["titel"].ToString(), Konstanten.foto));
                }
            }

            ergebnis.Show();
            
        }

        private TaskCollection aufgabenSuche(string name)
        {
            return new OutlookCommunication().getOutlookSession().Tasks.Items.Restrict("[Subject]=\"" + name + "\"");
            
        }

        private ContactCollection kontaktSuche(String name)
        {
            return new OutlookCommunication().getOutlookSession().Contacts.Items.Restrict("[LastName]=\"" + name + "\"");
        }

        private AppointmentCollection terminSuche(String name)
        {
            return new OutlookCommunication().getOutlookSession().Appointments.Items.Restrict("[Subject]=\"" + name + "\"");
        }       
    }
}