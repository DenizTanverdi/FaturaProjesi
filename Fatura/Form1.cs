using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIL f = new FormIL();
            f.Show();
        }

        private void ilceEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ilce ilce = new ilce();
            ilce.Show();

        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBirim frm = new FormBirim();
            frm.Show();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrun urn = new FormUrun();
            urn.Show();
        }

        private void müsteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriForm frm = new MusteriForm();
            frm.Show();
        }

        private void görüntüleSorgulaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yeniFaturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni frm = new FormYeni();
            frm.Show();
        }
    }
}
