using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{

    [Table("Ilce")]
    public class Ilce
    {
        [Key]
        public int IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int ILId { get; set; }
        public virtual IL il { get; set; }
        public virtual ICollection<Musteri> musteri { get; set; }
    }
}
