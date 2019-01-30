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

        }
    }
}
