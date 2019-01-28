using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fatura.Entity
{
    [Table("FaturaDetay")]
    public class FaturaDetay
    {

        public FaturaDetay()
        {
            this.Aciklama = "Vadesinden sonra ödenen faturalara %5 kanuni ceza faizi uygulanir";
        }
        [Key][Column(Order =0)]
        public int faturaId { get; set; }
        [Key][Column(Order = 1)]
        public int urunId { get; set; }
        public decimal miktar { get; set; }
        public decimal ToplamFiyat { get; set; }
        public decimal KDV { get; set; }
        public decimal KDVliFiyat { get; set; }
        public decimal FaturaToplami { get; set; }
        public string Aciklama { get; set; }
        public virtual FaturaMaster faturaMaster { get; set; }
        public virtual  Urunler urun { get; set; }
    }
}