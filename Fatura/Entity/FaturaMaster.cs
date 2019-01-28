using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Entity
{
    [Table("FaturaMaster")]
  public   class FaturaMaster
    {
        public FaturaMaster()
        {
            this.faturaDetay = new HashSet<FaturaDetay>();
            this.faturaTarihi = DateTime.Now;
        }
        [Key]
        public int faturaId { get; set; }
        public int musteriId { get; set; }
        public DateTime faturaTarihi { get; set; }
        public int  IrsaliyeNo { get; set; }
        public DateTime OdemeTarihi { get; set; }

        public virtual Musteri musteri { get; set; }
        public virtual ICollection<FaturaDetay> faturaDetay { get; set; }

    }
}
