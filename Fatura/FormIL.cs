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

        }
        public void Listele()
        {
            var list = db.il.Select(I => new { I.ILAdi, I.ILId }).ToList();
            dataGridView1.DataSource = list;
            txtBxIl.Clear();
            txtBxIl.Focus();
        }

        private void FormIL_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
