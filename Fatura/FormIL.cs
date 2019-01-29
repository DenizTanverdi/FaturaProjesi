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
    public partial class FormIL : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenId;
        public FormIL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IL il = new IL();
                il.ILAdi = txtBxIl.Text;
                db.il.Add(il);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                string str = ex.Message;
            }
            Listele();

        }
        public void Listele()
        {
            var list = db.il.Select(I => new { I.ILId, I.ILAdi }).ToList();
            dataGridView1.DataSource = list;
            txtBxIl.Clear();
            txtBxIl.Focus();
        }

        private void FormIL_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenId = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            IL il = db.il.Find(secilenId);
            txtBxIl.Text = il.ILAdi;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IL il = db.il.Find(secilenId);
                il.ILAdi = txtBxIl.Text;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("İL Seçmeniz Gerekmektedir.");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                IL il = db.il.Find(secilenId);
                db.il.Remove(il);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("İL Seçmeniz Gerekmektedir.");
            }
        }
    }
}
