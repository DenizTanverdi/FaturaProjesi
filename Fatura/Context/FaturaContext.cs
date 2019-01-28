using Fatura.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura.Context
{
     public class FaturaContext:DbContext
    {
        public FaturaContext():base ("name=baglanti")
        {

        }
        public virtual DbSet<FaturaMaster> faturamaster { get; set; }
        public virtual DbSet<FaturaDetay> faturadetay { get; set; }
        public virtual DbSet<Musteri> musteri { get; set; }
        public virtual DbSet<Birim> birim { get; set; }
        public virtual DbSet<Urunler> urun { get; set; }
        public virtual DbSet<IL> il { get; set; }
        public virtual DbSet<Ilce> ilce { get; set; }

    }
}
