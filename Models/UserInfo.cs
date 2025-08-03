using System.ComponentModel.DataAnnotations;

namespace MEETINGAPP.Models;

public class UserInfo
{
    public int Id { get; set; }
    [Required (ErrorMessage = "Ad ve Soyad alanı gereklidir.")]
    public string? Name { get; set; }

    [Required   (ErrorMessage = "E-posta alanı gereklidir.")]
    [EmailAddress]
    public string? Email { get; set; }

    [Required   (ErrorMessage = "Telefon alanı gereklidir.")]
    public string? Phone { get; set; }

    [Required   (ErrorMessage = "Katılım durumu gereklidir.")]
    public bool WillAttend { get; set; }
}
