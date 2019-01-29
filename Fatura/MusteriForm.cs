using Fatura.Context;
using Fatura.Entity;
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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        int secilenId;
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            ilDoldur();
            Listele();
        }

        private void Listele()
        {
            var musteriler = from m in db.musteri
                             select new
                             {
                                 m.musteriId,
                                 m.musteriAdi,
                                 m.musteriAdresi,
                                 m.ilce.IlceAdi,
                                 sehirAdi = m.ilce.il.ILAdi,
                             };
            dataGridView1.DataSource = musteriler.ToList();
            txtBxAdres.Clear();
            txtBxUnvan.Clear();
            txtBxUnvan.Focus();
        }

        private void ilDoldur()
        {
            var iller = from i in db.il select new { i.ILId, i.ILAdi };
            cmbxSehir.DisplayMember = "ILAdi";
            cmbxSehir.ValueMember = "ILId";
            cmbxSehir.DataSource = iller.ToList();
        }

        private void cmbxSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceDoldur();

        }

        private void ilceDoldur()
        {
            var list = db.ilce.Where(I => I.ILId == (int)cmbxSehir.SelectedValue).OrderBy(I => I.IlceAdi).Select(I => new { I.IlceId, I.IlceAdi, I.ILId }).ToList();

            cmbxIlce.DisplayMember = "IlceAdi";
            cmbxIlce.ValueMember = "IlceId";
            cmbxIlce.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.musteriAdi = txtBxUnvan.Text;
            m.musteriAdresi = txtBxAdres.Text;
            m.ilceId = (int)cmbxIlce.SelectedValue;
            db.musteri.Add(m);
            db.SaveChanges();
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri m =db.musteri.Find(secilenId);
            m.musteriAdresi = txtBxAdres.Text;
            m.musteriAdi = txtBxUnvan.Text;
            m.ilceId =(int) cmbxIlce.SelectedValue;
            db.SaveChanges();
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri m = db.musteri.Find(secilenId);
            db.musteri.Remove(m);
            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var musteri = db.musteri.Find(secilenId);
            txtBxAdres.Text = musteri.musteriAdresi;
            txtBxUnvan.Text = musteri.musteriAdi;
        }
    }
}
