using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Cariler
{
    public class Phone
    {
        
        public string Type { get; set; }
        public string Code { get; set; }
        [Phone(ErrorMessage = "Geçerli bir telefon numarası girin!")]
        public string Number { get; set; }
        public string Dahili { get; set; }
        public string Tanimi { get; set; }
    }
}
