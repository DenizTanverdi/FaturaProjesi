using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{
    [Table("Birim")]
    public class Birim
    {
        public Birim()
        {
            this.urun = new HashSet<Urunler>();
        }
        [Key]
        public int birimId { get; set; }
        public string birimAdi { get; set; }
        public virtual ICollection<Urunler> urun { get; set; }

    }
}
