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
    public partial class ilce : Form
    {
        FaturaContext db = new FaturaContext();
        public ilce()
        {
            InitializeComponent();
        }

        private void ilce_Load(object sender, EventArgs e)
        {
            ComboBoxListele();

            Listele();
        }
        public void ComboBoxListele()
        {
            try
            {
                var list = db.il.Select(x => new { x.ILId, x.ILAdi }).OrderBy(x => x.ILAdi).ToList();
                
                comboBox1.DisplayMember = "ILAdi";
                comboBox1.ValueMember = "ILId";
                comboBox1.DataSource = list;

            }
            catch (Exception ex )
            {

                throw;
            }
         

        }
        public void Listele()
        {
            try
            {
                int sayi = Convert.ToInt32(comboBox1.SelectedValue);
               var list=db.ilce.Select(x=>new { x.IlceId,
                                                 x.ILId,
                                                 x.IlceAdi,
                                                SehirAdi =x.il.ILAdi })
                    .Where(x=>x.ILId==(int)comboBox1.SelectedValue)
                    .OrderBy(x=>x.SehirAdi).ToList();
                //2.listeme yöntemi
                var list2 = from i in db.ilce
                            where i.ILId == sayi orderby(i.IlceAdi)
                            select new { i.ILId, i.IlceId, i.il.ILAdi, i.IlceAdi } ;
                dataGridView1.DataSource = list2.ToList();
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                txtBxIlce.Clear();
                txtBxIlce.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = new Ilce();
                ilce.IlceAdi = txtBxIlce.Text;
                ilce.ILId = (int)comboBox1.SelectedValue;
                db.ilce.Add(ilce);
                db.SaveChanges();


            }
            catch (Exception ex)
            {

                string str = ex.Message;
            }
            Listele();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
        int secilenId;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               Ilce ilce = db.ilce.Find(secilenId);
                ilce.IlceAdi = txtBxIlce.Text;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("İL Seçmeniz Gerekmektedir.");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBxIlce.Clear();
            secilenId = Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtBxIlce.Text = (dataGridView1.CurrentRow.Cells[3].Value.ToString());
            //  Ilce ilce = db.ilce.Find(secilenId);
            //txtBxIlce.Text = ilce.IlceAdi;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                Ilce ilce = db.ilce.Find(secilenId);
                db.ilce.Remove(ilce);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("İLÇE Seçmeniz Gerekmektedir.");

            }
        }
    }
}
