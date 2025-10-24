// Import for validation and data annotation attributes like [Required], [EmailAddress], etc.
using System.ComponentModel.DataAnnotations;

namespace M_UserLogin.ViewModels
{
    // 🧾 This ViewModel is used when a user logs in.
    // It holds the data entered in the Login form (email, password, remember me checkbox).
    public class LoginViewModel
    {
        // 📧 User must provide an email address to log in.
        // [Required] → Makes this field mandatory.
        // ErrorMessage → Message shown if the user leaves it blank.
        // [EmailAddress] → Ensures proper email format (e.g., name@example.com)
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string? Email { get; set; } // Nullable string (can be empty initially)

        // 🔑 Password field
        // [Required] → User must enter a password.
        // [DataType(DataType.Password)] → Ensures the input is treated as a password (hidden characters in the form).
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        // ✅ Checkbox for "Remember me" option on login page
        // [Display(Name = "Remember me?")] → Sets label text in the UI
        // Default value = true, so the box is pre-checked when the page loads
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } = true;
    }
}
