using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Adress
{
    public class Mahalle
    {
        public string MahalleName { get; set; }
        public List<string> Sokaklar { get; set; }
    }
}
