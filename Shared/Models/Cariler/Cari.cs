using SiparisApp.Shared.Models.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Cariler
{
    public class Cari
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public int AdresId { get; set; }
        public string Unvan { get; set; }
        public string Turu { get; set; }
        public string Cinsiyet { get; set; }
        public string Kodu { get; set; }
        public string Eposta { get; set; }
        public string YetkiAdi { get; set; } // Kurumsa yetki adı
        public string YetkiSoyadi { get; set; } // Kurumsa yetki soyadı
        public string Tip { get; set; } // Cari tipi (şahıs/kurum)
        public string TCKimlikNo { get; set; } // Şahıssa T.C. kimlik no
        public string VergiNo { get; set; } // Kurumsa vergi no
        public List<Phone> Telefonlar { get; set; } = new List<Phone>();
        public List<Email> Epostalar { get; set; } = new List<Email>();
        public List<Address> Adresler { get; set; } = new List<Address>();
    }
}
