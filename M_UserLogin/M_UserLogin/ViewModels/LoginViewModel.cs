using System.ComponentModel.DataAnnotations;

namespace M_UserLogin.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } = true;
    }
}
