// Import DataAnnotations library for form field validation attributes
using System.ComponentModel.DataAnnotations;

namespace M_UserLogin.ViewModels
{
    // 🧾 This ViewModel is used in the "Change Password" page.
    // It stores user input (email, new password, confirm new password)
    // and ensures all data is validated properly before saving.
    public class ChangePasswordViewModel
    {
        // 📧 User’s registered email address
        // [Required] → must not be empty.
        // [EmailAddress] → ensures a valid email format.
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }

        // 🔑 The new password user wants to set
        // [Required] → cannot be blank.
        // [StringLength] → must be between 8 and 40 characters.
        // [DataType(DataType.Password)] → hides input in the UI.
        // [Display(Name = "New Password")] → sets label name in the form.
        // [Compare("ConfirmNewPassword")] → checks both passwords match.
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "The {0} must be at {2} and at max {1} characters long.")]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
        public string NewPassword { get; set; }

        // ✅ Field for confirming the new password
        // Helps ensure user types their new password correctly
        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
