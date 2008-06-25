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

        public Foto(FotoInfo foto)
        {
            InitializeComponent();
            this.foto = foto;

            textBoxBeschreibung.Text = foto.getBeschreibung();
            textBoxBeschreibung.Text = foto.getTitel();
            pictureBox1.Image = new Bitmap(foto.getPfad());
        }


    }
}