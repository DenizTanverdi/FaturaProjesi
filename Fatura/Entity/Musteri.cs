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
        [Key]
        public int musteriId { get; set; }
        public string musteriAdi { get; set; }
        public int ilceId { get; set; }
        public string musteriAdresi { get; set; }
        public virtual Ilce ilce { get; set; }

        public virtual ICollection<FaturaMaster> FaturaMasters { get; set; }
    }
}
