using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace CafeBoost.Data
{
    [Table("Siparisler")]
    public class Siparis
    {
        public Siparis()
        {
            SiparisDetaylar = new HashSet<SiparisDetay>();
            AcilisZamani = DateTime.Now;
        }

        public int Id { get; set; }

        public int MasaNo { get; set; }

        public DateTime? AcilisZamani { get; set; }

        public DateTime? KapanisZamani { get; set; }

        public SiparisDurum Durum { get; set; }

        public decimal OdenenTutar { get; set; }

        public string ToplamTutarTL => $"{ToplamTutar():0.00}₺";


        public virtual ICollection<SiparisDetay> SiparisDetaylar { get; set; }



        public decimal ToplamTutar() => SiparisDetaylar.Sum(x => x.Tutar());
    }
}
