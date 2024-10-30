using SiparisApp.Shared.Models.Adress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Cariler
{
    public class CariModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string Unvan { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public int AdresId { get; set; }
        
    }
}
