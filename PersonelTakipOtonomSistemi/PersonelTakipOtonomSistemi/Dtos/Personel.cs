using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipOtonomSistemi.Dtos
{
    internal class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string TelefonNo { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public string TCKimlikNo { get; set; }
        public string Departman { get; set; }
        public string Pozisyon { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
    }
}
