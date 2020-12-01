using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CafeBoost.Data
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay
    {
        public int Id { get; set; }

        public int UrunId { get; set; }

        public int SiparisId { get; set; }

        [Required, MaxLength(100)]
        public string UrunAd { get; set; }

        public decimal BirimFiyat { get; set; }

        public int Adet { get; set; }

        public string TutarTL { get { return $"{Tutar():0.00}TL"; } }

        public virtual Urun Urun { get; set; }

        public virtual Siparis Siparis { get; set; }

        public decimal Tutar()
        {
            return Adet * BirimFiyat;
        }
    }
}
