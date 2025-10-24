// Import DataAnnotations for form field validation attributes
using System.ComponentModel.DataAnnotations;

namespace M_UserLogin.ViewModels
{
    // 🧾 This ViewModel is used on the "Verify Email" page.
    // It captures the user's email to check if an account exists
    // before allowing password reset or other sensitive actions.
    public class VerifyEmailViewModel
    {
        // 📧 Email field entered by the user
        // [Required] → Must not be empty.
        // [EmailAddress] → Must be in valid email format (e.g., name@example.com).
        // If invalid or missing, form will not submit and show the given error message.
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
