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
    public partial class Foto : Form
    {
        FotoInfo foto;
        bool neuesFoto;
        DB_Verarbeitung db = new DB_Verarbeitung();
        Fotos guiFotos = null;
        ListViewItem item = null;

        public Foto(FotoInfo foto, bool neuesFoto, Fotos guiFotos, ListViewItem item)
        {
            InitializeComponent();
            this.foto = foto;
            this.neuesFoto = neuesFoto;
            pictureBox1.Image = new Bitmap(foto.getPfad());
            this.guiFotos = guiFotos;
            this.item = item;
        }

        private void menuItemAbbrechen_Click(object sender, EventArgs e)
        {
            if (neuesFoto)
            {
                db.fotoLoeschen(foto);
            }
            
            this.Dispose();
            this.Close(); 

        }

        private void menuItemSpeichern_Click(object sender, EventArgs e)
        {
            this.guiFotos.titelAendern(this.foto.getTitel(),textBoxTitel.Text, item);
            foto.setBeschreibung(textBoxBeschreibung.Text);
            foto.setTitel(textBoxTitel.Text);
            db.fotoAendern(this.foto);
            this.Dispose();
            this.Close();
        }

    }
}