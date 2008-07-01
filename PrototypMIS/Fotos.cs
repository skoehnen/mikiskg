using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.WindowsMobile.Status;
using Microsoft.WindowsMobile.Forms;
using Microsoft.WindowsMobile.PocketOutlook;


namespace PrototypMIS
{
    public partial class Fotos : Form
    {

        DB_Verarbeitung db = new DB_Verarbeitung();

        public Fotos()
        {
            InitializeComponent();
            ColumnHeader test = new ColumnHeader();
            test.Text = "Test";
            listView1.Columns.Add("test", 10, HorizontalAlignment.Center);
        }

        private void menuItemZueruck_Click(object sender, EventArgs e)
        {
            Dispose();
            this.Close();
        }

        private void menuItemFoto_Click(object sender, EventArgs e)
        {
            String bildPfad = fotoMachen();
            String titel = Guid.NewGuid().ToString();
            this.bildHinzufuegen(bildPfad, titel);
            db.fotoEinfuegen(bildPfad, "", titel);
            new Foto(db.fotoHolen(titel),true, this).Show();
        }

        private String fotoMachen()
        {
            CameraCaptureDialog myCamDialog = new CameraCaptureDialog();
            myCamDialog.DefaultFileName = Guid.NewGuid().ToString() +
            ".jpg";
            String dateiName = "FEHLER";
            if (myCamDialog.ShowDialog() == DialogResult.OK)
            {
                Image thisPicture;
                thisPicture = new Bitmap(myCamDialog.FileName);
                dateiName = myCamDialog.FileName;
            }
            return dateiName;
        }

        private void bildHinzufuegen(String pfad, String titel)
        {
            if (pfad != "")
            {
                imageList1.Images.Add(Image.FromHbitmap(new Bitmap(pfad).GetHbitmap()));
                int i = imageList1.Images.Count -1;
                ListViewItem item = new ListViewItem();
                item.Text = titel;
                item.ImageIndex = i;
                listView1.Items.Add(item);
            }
        }

        public void titelAendern(String titelAlt, String titelNeu)
        {
            int i = listView1.Items.IndexOf(new ListViewItem(titelAlt));
            listView1.Items[i].Text = titelNeu;
        }

        private void menuItemShow_Click(object sender, EventArgs e)
        {
            String titel = listView1.FocusedItem.Text;
            new Foto(db.fotoHolen(titel), false, this).Show();
        }

        private void menuItemDelete_Click(object sender, EventArgs e)
        {
            String titel = listView1.FocusedItem.Text;
            db.fotoLoeschen(titel);
        }
    }
}