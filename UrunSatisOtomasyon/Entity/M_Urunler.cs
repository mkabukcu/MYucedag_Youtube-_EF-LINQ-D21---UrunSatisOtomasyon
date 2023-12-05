using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UrunSatisOtomasyon.Entity
{
    public class M_Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public string Aciklama { get; set; }
        public int UrunStok { get; set; }

        public M_Kategoriler Kategori { get; set; }
    }
}
