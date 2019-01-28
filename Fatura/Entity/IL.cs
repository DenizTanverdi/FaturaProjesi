using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{
    [Table("IL")]
    public class IL
    {
        [Key]
        public int ILId { get; set; }
        public string ILAdi { get; set; }
        public virtual ICollection<Ilce> ilce { get; set; }
    }
}
