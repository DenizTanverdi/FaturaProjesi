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
    public partial class Urun : Form
    {
        FaturaContext db = new FaturaContext();
        public Urun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            ComboBoxListele();
        }
        public void ComboBoxListele()
        {
            try
            {
                var list = db.birim.Select(x => new { x.birimId, x.birimAdi })
                    .OrderBy(x => x.birimAdi).ToList();

                comboBox1.DisplayMember = "birimId";
                comboBox1.ValueMember = "birimAdi";
                comboBox1.DataSource = list;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void Listele()
        {
            try
            {
                var list = db.urun.Select(x => new { x.urunId, x.urunKodu,x.urunAdi,x.birimFiyat })
                    .OrderBy(x => x.birimAdi).ToList();

                comboBox1.DisplayMember = "birimId";
                comboBox1.ValueMember = "birimAdi";
                comboBox1.DataSource = list;
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
