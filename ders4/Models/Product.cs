using System.ComponentModel.DataAnnotations;

namespace ders4.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Lütfen product Name ı gırınız")] //
        [StringLength(100,ErrorMessage ="lutfen product name ı en fazla 100 karakter gırıniz")]
        public string ProductName { get; set; }
        public int Quentity { get; set; }
        [EmailAddress(ErrorMessage ="lütfen dogru bır email adresi giriniz.")]
        public string Email { get; set; }
    }
}
