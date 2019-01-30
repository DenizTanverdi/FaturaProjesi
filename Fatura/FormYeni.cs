using Fatura.Context;
using Fatura.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private void IlceDoldur()
        {
            var list = from i in db.ilce where i.ILId == (int)comboSehir.SelectedValue select new { i.IlceId, i.IlceAdi };
            comboİlce.DisplayMember = "IlceAdi";
            comboİlce.ValueMember = "IlceId";
            comboİlce.DataSource = list.ToList();
        }

        private void comboSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunListesi.Add(
                new SecilenUrun
                {
                    UrunId = (int)comboUrunAdi.SelectedValue,
                    UrunAdi = comboUrunAdi.Text,
                    Kdv = Convert.ToDecimal(textKdv.Text),
                    urunFiyat = Convert.ToDecimal(textUrunFiyati.Text),
                    miktar = Convert.ToDecimal(UrunMiktari.Value),
                    toplamTutar = Convert.ToDecimal(textUrunFiyati.Text) * Convert.ToDecimal(UrunMiktari.Value)
                });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunListesi.Where(x => x.UrunId == secilenId).FirstOrDefault();
                if (secilenId==(int)comboUrunAdi.SelectedValue)
                {
                    urun.miktar = (decimal)UrunMiktari.Value;
                    urun.toplamTutar = Convert.ToDecimal(textUrunFiyati.Text) * Convert.ToDecimal(UrunMiktari.Value);
                }
                else
                {
                    urun.UrunId = (int)comboUrunAdi.SelectedValue;
                    urun.UrunAdi = comboUrunAdi.Text;
                    urun.urunFiyat = Convert.ToDecimal(textUrunFiyati.Text);
                    urun.miktar = Convert.ToDecimal(UrunMiktari.Value);
                    urun.toplamTutar = Convert.ToDecimal(textUrunFiyati.Text) * Convert.ToDecimal(UrunMiktari.Value);

                }
                listele();
            }
            catch (Exception)
           {

                MessageBox.Show("Listeden Ürün Seçiniz.");
            }
        }

        private void listele()
        {
            dataGridView1.DataSource = urunListesi.Select(I=>new
            {   I.UrunId,
                I.UrunAdi,
                I.urunFiyat,
                I.miktar,
                I.Kdv,
                I.toplamTutar,
                GenelToplam =I.toplamTutar+(I.toplamTutar*I.Kdv/100)
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
        }
        private void temizle()
        {
            UrunMiktari.Value = 0;
        }
        private void faturaToplam()
        {
            decimal toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToDecimal(dataGridView1[6, i].Value);
            }
            labeltoplam.Text += " "+toplam.ToString("{0:0.00}")+" TL";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var urun = urunListesi.Where(i => i.UrunId == secilenId).FirstOrDefault();
            urunListesi.Remove(urun);
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = db.Database.BeginTransaction();

            try
            {
                faturaMasterKaydet();
                faturaDetayKaydet();
              
            }
            catch (Exception)
            {

                tran.Rollback();
                MessageBox.Show("BEKLENMEYEN HATA İLE KARŞILASTI.");
            }
        }

        private void faturaDetayKaydet()
        {
            FaturaDetay dty = new FaturaDetay();
            dty.urunId = (int)comboUrunAdi.SelectedValue;
            dty.faturaId=
        dty.
                }

        private void faturaMasterKaydet()
        {
            FaturaMaster fm = new FaturaMaster();
            fm.IrsaliyeNo = Convert.ToInt32(textIrsaliyeNo.Text);
            fm.OdemeTarihi = dateTimeOdeme.Value;
            fm.musteriId = (int)comboMusteri.SelectedValue;
            db.faturamaster.Add(fm);
            db.SaveChanges();
            label1.Text = fm.faturaId.ToString();

        }
    }
}
