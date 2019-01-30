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
using Fatura.Entity;

namespace Fatura
{
    public partial class FormUrun : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        public FormUrun()
        {
            InitializeComponent();
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            ComboBoxListele();
            Listele();
        }
        public void ComboBoxListele()
        {
            try
            {
                var list = db.birim.Select(x => new { x.birimId, x.birimAdi })
                    .OrderBy(x => x.birimAdi).ToList();

                comboBox1.DisplayMember = "birimAdi";
                comboBox1.ValueMember = "birimId";
                comboBox1.DataSource = list;
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Urunler urn = new Urunler();
                urn.urunKodu = txtBxKod.Text;
                urn.urunAdi = txtBxAd.Text;
                urn.birimId = (int)comboBox1.SelectedValue;
                urn.birimFiyat =Convert.ToDecimal(txtBxBirimF.Text);
                db.urun.Add(urn);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                string str ="Bütün Alanları Doldurunuz.";
            }
            Listele();
        }
        public void Listele()
        {
            try
            {
                var list = db.urun.Select(x => new { x.urunId, x.urunKodu,x.urunAdi,x.birimFiyat,x.birim.birimAdi })
                    .ToList();

                dataGridView1.DataSource = list;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Urunler u = db.urun.Find(secilenId);
            u.urunAdi = txtBxAd.Text;
            u.urunKodu = txtBxKod.Text;
            u.birimFiyat = Convert.ToDecimal(txtBxBirimF.Text);
           u.birimId = (int)comboBox1.SelectedValue;
            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Urunler u = db.urun.Find(secilenId);
                txtBxAd.Text = u.urunAdi;
                txtBxBirimF.Text = (u.birimFiyat).ToString();
                txtBxKod.Text = u.urunKodu;
                comboBox1.SelectedValue = u.birim.birimId;
            }
            catch (Exception)
            {

                return;
            }
           
                   }

        private void button3_Click(object sender, EventArgs e)
        {
            Urunler u = db.urun.Find(secilenId);
            db.urun.Remove(u);
            db.SaveChanges();
            Listele();
        }
    }
}
