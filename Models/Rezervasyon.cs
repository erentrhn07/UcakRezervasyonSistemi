using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonSistemi.Models
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public int UcakId { get; set; }
        public Ucak Ucak { get; set; }
        public DateTime Tarih { get; set; }
        public int KoltukNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public bool Satildi { get; set; }
    }
}
