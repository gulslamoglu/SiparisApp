using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models
{
    public class IskontoMasraf
    {
        public string Turu { get; set; }
        public string Hesaplama { get; set; }
        public decimal Miktar { get; set; }
        public decimal Hesaplanan { get; set; }
        public string Aciklama { get; set; }

    }
}
