using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunSatisOtomasyon.Entity
{
    public class M_Kategoriler
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
        public string KategoriAciklama { get; set; }

        public ICollection<M_Urunler> M_Urunlers { get; set; }
    }
}
