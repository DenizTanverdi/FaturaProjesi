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
    public partial class FormBirim : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        public FormBirim()
        {
            InitializeComponent();
        }
        public void Listele()
        {
            var list = db.birim.Select(I => new { I.birimId, I.birimAdi }).ToList();
            dataGridView1.DataSource = list;
            txtBxBirim.Clear();
            txtBxBirim.Focus();
        }

        private void FormBirim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Birim brm = new Birim();
               brm.birimAdi = txtBxBirim.Text;
                db.birim.Add(brm);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                string str = ex.Message;
            }
            Listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Birim brm = db.birim.Find(secilenId);
                brm.birimAdi = txtBxBirim.Text;
                
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Birim Seçmeniz Gerekmektedir.");

            }
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtBxBirim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Birim brm = db.birim.Find(secilenId);
                db.birim.Remove(brm);

                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Birim Seçmeniz Gerekmektedir.");

            }
            Listele();
        }
    }
}
