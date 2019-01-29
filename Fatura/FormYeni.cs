using Fatura.Context;
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
    public partial class FormYeni : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        List<SecilenUrun> urunListesi = new List<SecilenUrun>();

        public FormYeni()
        {
            InitializeComponent();
        }

        private void FormYeni_Load(object sender, EventArgs e)
        {
            MusteriSehriDoldur();
            urunDoldur();

        }

        private void urunDoldur()
        {
            var list = db.urun.OrderBy(I => I.urunAdi).Select(I => new { I.urunId, I.urunAdi });
            comboUrunAdi.ValueMember = "UrunId";
            comboUrunAdi.DisplayMember = "UrunAdi";
            comboUrunAdi.DataSource = list;
        }

        private void MusteriSehriDoldur()
        {
            var list = db.il.ToList();
            comboSehir.ValueMember = "ILId";
            comboSehir.DisplayMember = "ILAdi";
            comboSehir.DataSource = list;
        }
    }
}
