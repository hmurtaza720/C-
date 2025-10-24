// Importing DataAnnotations library for form validation attributes
using System.ComponentModel.DataAnnotations;

namespace M_UserLogin.ViewModels
{
    // 🧾 This ViewModel handles user registration data.
    // It is used in the Register view and passed to the AccountController.
    public class RegisterViewModel
    {
        // 🧍‍♂️ User’s full name
        // [Required] → field must not be empty.
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        // 📧 User’s email address
        // [Required] → email must be provided.
        // [EmailAddress] → must follow valid email format.
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        // 🔑 User’s password
        // [Required] → cannot be empty.
        // [StringLength] → must be between 8 and 40 characters.
        // [DataType(DataType.Password)] → hides password input in forms.
        // [Compare("ConfirmPassword")] → checks if password matches ConfirmPassword.
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match.")]
        public string Password { get; set; }

        // ✅ Confirm password field
        // Used to double-check password accuracy
        // [Display(Name = "Confirm Password")] → sets label name in the form.
        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
