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
        ImageList imageListMiki = new ImageList();

        public Fotos()
        {
            InitializeComponent();

            ListViewItem item1 = new ListViewItem("item1");
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2");
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3");
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            listView1.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);

            listView1.LargeImageList = imageListMiki;

        }

        private void menuItemZueruck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemFoto_Click(object sender, EventArgs e)
        {
            String bildPfad = fotoMachen();
            String titel = Guid.NewGuid().ToString();
            db.fotoEinfuegen(bildPfad, "", titel);
            new Foto(db.fotoHolen(titel),true).Show();
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
            this.bildHinzufuegen(dateiName);
            return dateiName;
        }

        private void bildHinzufuegen(String pfad)
        {
            if (pfad != "")
            {
                imageListMiki.Images.Add(Image.FromHbitmap(new Bitmap(pfad).GetHbitmap()));
            }
        }
    }
}