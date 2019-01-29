using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura
{
    public class SecilenUrun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public decimal miktar { get; set; }
        public decimal urunFiyat { get; set; }
        public decimal toplamTutar { get; set; }
        public decimal Kdv { get; set; }
    }
}
