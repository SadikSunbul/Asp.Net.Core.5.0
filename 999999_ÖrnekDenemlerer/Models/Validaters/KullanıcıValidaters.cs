using FluentValidation;
using System.Data;

namespace _999999_ÖrnekDenemlerer.Models.Validaters
{
    public class KullanıcıValidaters:AbstractValidator<Kullanıcı>
    {
        public KullanıcıValidaters()
        {
            RuleFor(i => i.KullanıcıAdı).NotNull().NotEmpty().WithMessage("Kullanıcı adı bos gecılemez");
            RuleFor(i => i.Email).NotNull().NotEmpty().WithMessage("Mail alanı bos geçilemez");
                 RuleFor(x => x.Email).EmailAddress().WithMessage("Dogru bır emaıl gırınız");

            RuleFor(i => i.Şİfre).NotNull().NotEmpty().WithMessage("Şifre alanı bos geçilemez");
            

        }
    }
}
