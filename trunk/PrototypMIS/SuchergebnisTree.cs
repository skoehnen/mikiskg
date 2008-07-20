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
    public partial class SuchergebnisTree : Form
    {
        int id = 0;
        int sourceTyp = -1;
        MikiDuo auswahl = null;

        public SuchergebnisTree()
        {
            InitializeComponent();
            this.addNewParents();
        }

        public SuchergebnisTree(int id, int typ)
        {
            InitializeComponent();
            this.id = id;
            this.addNewParents();
            this.sourceTyp = typ;
        }


        /// <summary>
        /// Einfügen eines neuen Parents
        /// </summary>
        /// <param name="text">Name des Parents</param>
        private void addNewParents()
        {
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("Kontakte 0 gefunden");
            treeView1.Nodes.Add("Aufgaben 0 gefunden");
            treeView1.Nodes.Add("Notizen 0 gefunden");
            treeView1.Nodes.Add("Termine 0 gefunden");
            treeView1.Nodes.Add("Kunden 0 gefunden");
            treeView1.Nodes.Add("Fotos 0 gefunden");
            treeView1.EndUpdate();
        }

        /// <summary>
        /// Methode die Anzahl der Fund im TreeView ausgibt
        /// </summary>
        /// <param name="parent">Parent der ergänzt werden soll</param>
        /// <param name="count">Anzahl der Funde</param>
        public void setFound(int parent, int count)
        {
            switch (parent)
            {
                case 0:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[0].Text = "Kontakte " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
                case 1:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[1].Text = "Aufgaben " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
                case 2:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[2].Text = "Notizen " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
                case 3:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[3].Text = "Termine " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
                case 4:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[4].Text = "Kunden " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
                case 5:
                    this.treeView1.BeginUpdate();
                    this.treeView1.Nodes[5].Text = "Fotos " + count.ToString() + " gefunden";
                    this.treeView1.EndUpdate();
                    break;
            }
        }

        /// <summary>
        /// Chield zum TreeView hinzufügen
        /// </summary>
        /// <param name="i">Parent unter dem es zugeordnet ist</param>
        /// <param name="node">Node</param>
        public void addNewChield(int i, MikiTreeNode node)
        {
            treeView1.BeginUpdate();
            treeView1.Nodes[i].Nodes.Add(node);
            treeView1.EndUpdate();
        }

        /// <summary>
        /// Form schließen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuItemBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuItemShow_Click(object sender, EventArgs e)
        {
            this.auswahl = (MikiDuo)this.treeView1.SelectedNode.Tag;
            switch (auswahl.typ)
            {
                case Konstanten.kontakt:
                    new Kontakt(new ItemId(auswahl.id)).Show();
                    break;

                case Konstanten.aufgabe:
                    new Aufgabe(new ItemId(auswahl.id)).Show();
                    break;

                case Konstanten.termin:
                    new Termin(new ItemId(auswahl.id)).Show();
                    break;

                case Konstanten.notiz:
                    //Noch zu implementieren
                    new Notiz().Show();
                    break;

                case Konstanten.foto:
                    //Noch zu implementieren
                    //new Foto().Show();
                    break;
            }
        }

        private void contextMenuItemLink_Click(object sender, EventArgs e)
        {
            DB_Verarbeitung db = new DB_Verarbeitung();
            this.auswahl = (MikiDuo)this.treeView1.SelectedNode.Tag;
            db.verknuepfung_eintragen(id, auswahl.id, sourceTyp, auswahl.typ);
            this.Close();
            this.Dispose();
        }
    }
}