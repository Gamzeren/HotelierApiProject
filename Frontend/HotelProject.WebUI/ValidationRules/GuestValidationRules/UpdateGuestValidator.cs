using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class UpdateGuestValidator:AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez!")
               .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!")
               .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyisim alanı boş geçilemez!")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!")
                .MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez!")
                .MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız!")
                .MaximumLength(15).WithMessage("Lütfen en fazla 15 karakter girişi yapınız!");
        }
    }
}
