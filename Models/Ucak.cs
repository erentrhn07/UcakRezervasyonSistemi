using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakRezervasyonSistemi.Models
{
        public class Ucak
    {
        public int UcakId { get; set; }
        public string Model { get; set; }
        public string Marka { get; set; }
        public string SeriNo { get; set; }
        public int KoltukKapasitesi { get; set; }
    }
}
