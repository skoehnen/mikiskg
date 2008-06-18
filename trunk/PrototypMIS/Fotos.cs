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
        public Fotos()
        {
            InitializeComponent();
        }

        private void menuItemZueruck_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void menuItemFoto_Click(object sender, EventArgs e)
        {
            CameraCaptureDialog myCamDialog = new CameraCaptureDialog();
            myCamDialog.DefaultFileName = Guid.NewGuid().ToString() +
            ".jpg";
            if (myCamDialog.ShowDialog() == DialogResult.OK)
            {
                Image thisPicture;
                String dateiName;
                thisPicture = new Bitmap(myCamDialog.FileName);
                dateiName = myCamDialog.FileName;
            }
        }
    }
}