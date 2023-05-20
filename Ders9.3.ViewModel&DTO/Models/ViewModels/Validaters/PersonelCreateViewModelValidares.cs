using FluentValidation;

namespace Ders9._3.ViewModel_DTO.Models.ViewModels.Validaters
{
    public class PersonelCreateViewModelValidares:AbstractValidator<PersonelCreateViewModel>
    {
        public PersonelCreateViewModelValidares()
        {
            RuleFor(x => x.Adi).NotNull().NotEmpty().WithMessage("Ad bos olamaz");
        }
    }
}
