using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{
    [Table("Musteri")]
    public class Musteri
    {
        public Musteri()
        {
            this.FaturaMaster = new HashSet<FaturaMaster>();

        }
        [Key]
        public int musteriId { get; set; }
        public string musteriAdi { get; set; }
        public int ilceId { get; set; }
        public string musteriAdresi { get; set; }
        public virtual Ilce ilce { get; set; }

        public virtual ICollection<FaturaMaster> FaturaMaster { get; set; }
    }
}
