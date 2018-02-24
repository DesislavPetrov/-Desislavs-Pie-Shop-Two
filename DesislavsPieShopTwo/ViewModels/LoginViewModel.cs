using System.ComponentModel.DataAnnotations;

namespace DesislavsPieShopTwo.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType (DataType.Password)]
        public string Password { get; set; }
    }
}
