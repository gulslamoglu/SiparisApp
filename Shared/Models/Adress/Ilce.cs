using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Adress
{
    public class Ilce
    {
        public string IlceName { get; set; }
        public List<Mahalle> Mahalleler { get; set; }
    }
}
