using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ders4.Models.ModelDateTyps
{
    
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Lütfen product Name ı gırınız")] //
        [StringLength(100, ErrorMessage = "lutfen product name ı en fazla 100 karakter gırıniz")]
        public string ProductName { get; set; }
        [EmailAddress(ErrorMessage = "lütfen dogru bır email adresi giriniz.")]
        public string Email { get; set; }

        //buradakı ama sadece valıdatıonlara aıt bır sınıf tasarlamak
    }
}
