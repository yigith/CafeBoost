using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CafeBoost.Data
{
    [Table("Urunler")]
    public class Urun
    {
        public Urun()
        {
            // yeni ürün oluşturduğumuzda boş liste ile başlasın, metotlarını kullanabilmek için
            SiparisDetaylar = new HashSet<SiparisDetay>();
        }

        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1:0.00}₺)", UrunAd, BirimFiyat); 
        }

        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }
    }
}
