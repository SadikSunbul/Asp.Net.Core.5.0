using FluentValidation;

namespace ders4.Models.Validaters
{
    public class ProductValidater:AbstractValidator<Product>
    {
        public ProductValidater()
        {
            RuleFor(x => x.Email).NotNull().WithMessage("Email bos olamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Dogru bır emaıl gırınız");

            RuleFor(x => x.ProductName).NotNull().NotEmpty().WithMessage("lutfen product name ı gırınız");
            RuleFor(x => x.ProductName).MaximumLength(100).WithMessage("Lutfen product naem ı 100 karakterden fazla gırmeyınız....");
        }
    }
}
