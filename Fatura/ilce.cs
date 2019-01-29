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
            var list = db.il.Select(x => new { x.ILId, x.ILAdi }).OrderBy(x=>x.ILAdi).ToList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "ILAdi";
            comboBox1.ValueMember = "ILId";

        }
        public void Listele()
        {
            try
            {
                var list=db.ilce.Select(x=>new { x.IlceId, x.ILId,x.IlceAdi,SehirAdi=x.il.ILAdi })
                    .Where(x=>x.ILId==Int32.Parse(comboBox1.SelectedValue.ToString()))
                    .OrderBy(x=>x.SehirAdi).ToList();
                //2.listeme yöntemi
                var list2 = from i in db.ilce
                            where i.ILId == Int32.Parse(comboBox1.SelectedValue.ToString())
                            select new { i.ILId, i.IlceId, i.il.ILAdi, i.IlceAdi };
                dataGridView1.DataSource = list2;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                txtBxIlce.Clear();
                txtBxIlce.Focus();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
