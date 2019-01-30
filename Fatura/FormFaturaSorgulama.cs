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
    public partial class FormFaturaSorgulama : Form
    {
        FaturaContext db = new FaturaContext();
        public FormFaturaSorgulama()
        {
            InitializeComponent();
        }

        private void FormFaturaSorgulama_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            listele();
        }

        private void listele()
        {
            dataGridView1.DataSource = (from f in db.faturamaster
                                        where f.faturaId == Convert.ToInt32(txtBxFaturaNo.Text)
                                        orderby f.faturaTarihi descending
                                        select new
                                        {

                                            f.faturaId,
                                            f.musteriId,
                                            f.musteri.musteriAdi,
                                            f.faturaTarihi,
                                            f.OdemeTarihi,
                                            f.IrsaliyeNo,
                                            sehir = f.musteri.ilce.il.ILAdi,
                                            ilce = f.musteri.ilce.IlceAdi
                                        }).ToList() ;
        }

        private void MusteriSehirDoldur()
        {
            var list = db.il.ToList();{


}
            comboSehir.DisplayMember = "ILAdi";
            comboSehir.ValueMember = "ILId";
            comboSehir.DataSource = list;
        }

        private void comboSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriIlceDoldur();
        }

        private void MusteriIlceDoldur()
        {
            var list = db.ilce.Where(I => I.IlceId.ToString().Contains(comboSehir.SelectedValue.ToString())).ToList();
            comboIlce.DisplayMember = "IlceAdi";
            comboIlce.ValueMember = "IlceId";
            comboIlce.DataSource = list;
        }

        private void comboIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = db.musteri.Where(I => I.ilceId == (int)comboIlce.SelectedValue).ToList();
            comboMusteri.ValueMember = "MusteriId";
            comboMusteri.DisplayMember = "MusteriAdi";
            comboMusteri.DataSource = list;
        }

        private void comboMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from fm in db.faturamaster
                                        where fm.musteriId == (int)comboMusteri.SelectedValue
                                        orderby fm.faturaTarihi descending
                                        select new
                                        {

                                            fm.faturaId,
                                            fm.musteriId,
                                            fm.musteri.musteriAdi,
                                            sehir=fm.musteri.ilce.il.ILAdi,
                                            ilce=fm.musteri.ilce.IlceAdi,
                                            fm.faturaTarihi,
                                            fm.IrsaliyeNo,
                                            fm.OdemeTarihi,



                                        }).ToList();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from fm in db.faturamaster
                                        orderby fm.faturaTarihi descending
                                        select new
                                        {

                                            fm.faturaId,
                                            fm.musteriId,
                                            fm.musteri.musteriAdi,
                                            sehir = fm.musteri.ilce.il.ILAdi,
                                            ilce = fm.musteri.ilce.IlceAdi,
                                            fm.faturaTarihi,
                                            fm.IrsaliyeNo,
                                            fm.OdemeTarihi,



                                        }).ToList();
        }

        private void txtBxFaturaNo_TextChanged(object sender, EventArgs e)
        {
            listele();
        }
    }
}
