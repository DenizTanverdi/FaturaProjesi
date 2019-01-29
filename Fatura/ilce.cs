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

        }
        public void ComboBoxListele()
        {
            var list = db.il.Select(x => new { x.ILId, x.ILAdi }).OrderBy(x=>x.ILAdi).ToList();
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "ILAdi";
            comboBox1.ValueMember = "ILId";

        }
    }
}
