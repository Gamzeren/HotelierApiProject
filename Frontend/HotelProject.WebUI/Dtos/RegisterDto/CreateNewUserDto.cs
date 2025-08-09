using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad Alanı boş geçilemez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanı boş geçilemez!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanıcı Adı Alanı boş geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail Alanı boş geçilemez!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre Alanı boş geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrarı Alanı boş geçilemez!")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }
        //public int WorkLocationID { get; set; }
        public String ImageUrl { get; set; }
    }
}
