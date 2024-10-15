using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisApp.Shared.Models.Adress
{
    public class Address
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adres başlığı seçmelisiniz!")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Tanım boş bırakılamaz!")]
        [StringLength(100, ErrorMessage = "Tanımı en fazla 100 karakter olabilir.")]
        public string Tanimi { get; set; }

        [Required(ErrorMessage = "Ülke seçmelisiniz!")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Şehir seçmelisiniz!")]
        public string City { get; set; }

        [Required(ErrorMessage = "İlçe seçmelisiniz!")]
        public string District { get; set; }

        [Required(ErrorMessage = "Mahalle seçmelisiniz!")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "Posta kodu boş bırakılamaz!")]
        [RegularExpression("^[0-9]{5}$", ErrorMessage = "Geçerli bir posta kodu girin (5 rakam)!")]
        public string postaKodu { get; set; }

        [Required(ErrorMessage = "Adres bilgisi boş bırakılamaz!")]
        [StringLength(500, ErrorMessage = "Açık adres en fazla 500 karakter olabilir.")]
        public string AcikAdres { get; set; }

        public bool IsDefault { get; set; }
    }


}
