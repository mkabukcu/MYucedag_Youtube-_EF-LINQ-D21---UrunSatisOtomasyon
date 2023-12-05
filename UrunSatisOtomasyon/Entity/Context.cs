using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UrunSatisOtomasyon.Entity
{
    class Context:DbContext
    {
        public DbSet<M_Urunler> Urunlers {get;set;}
        public DbSet<M_Kategoriler> Kategorilers { get; set; }
        public DbSet<M_Musteriler> Musterilers { get; set; }

    }
}
