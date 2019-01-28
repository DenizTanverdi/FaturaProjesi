using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{

    [Table("Urun")]
    public class Urunler
    {
        [Key]
        public int urunId { get; set; }
        public string urunAdi { get; set; }
        public string urunKodu { get; set; }
        public int birimId { get; set; }
        public decimal birimFiyat { get; set; }
        public virtual  Birim birim { get; set; }

    }
}
