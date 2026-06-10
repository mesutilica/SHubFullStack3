using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // validasyon işlemleri için gerekli namespace

namespace NetCoreMVCEgitimi.Models
{
    [Table("Uyeler")] // Veritabanında tablo adı "Uyeler" olacak şekilde ayarlanır
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur."), StringLength(50)]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyad alanı zorunludur."), StringLength(50)]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Email alanı zorunludur."), StringLength(50), EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string? Telefon { get; set; }
        [Display(Name = "TC Kimlik No"), StringLength(11, MinimumLength = 11, ErrorMessage = "TC Kimlik No 11 karakter olmalıdır.")]
        [MaxLength(11, ErrorMessage = "TC Numarası 11 Karakter Olmalıdır!")]
        public string? TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string? KullaniciAdi { get; set; }
        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [Display(Name = "Şifre"), DataType(DataType.Password)]
        public string Sifre { get; set; }
        [Required(ErrorMessage = "Şifre tekrar alanı zorunludur.")]
        [Display(Name = "Şifre Tekrar"), DataType(DataType.Password)]
        [Compare("Sifre", ErrorMessage = "Şifreler eşleşmiyor.")]
        public string SifreTekrar { get; set; }
    }
}
