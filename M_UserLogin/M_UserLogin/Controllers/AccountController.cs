using M_UserLogin.Models;                  // Importing Models (like Users class)
using M_UserLogin.ViewModels;              // Importing ViewModels (like LoginViewModel, RegisterViewModel)
using Microsoft.AspNetCore.Identity;       // For Identity framework (UserManager, SignInManager)
using Microsoft.AspNetCore.Mvc;

namespace M_UserLogin.Controllers
{
    // 👤 This controller handles all user-related actions (Login, Register, Forgot Password, Logout)
    public class AccountController : Controller
    {
        // ✳️ Injecting Identity classes
        // UserManager: helps to create, update, and manage users
        // SignInManager: handles login/logout functionality
        private readonly SignInManager<Users> signInManager;
        private readonly UserManager<Users> userManager;

        // 🧱 Constructor - called automatically when controller is created
        public AccountController(SignInManager<Users> signInManager, UserManager<Users> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        // ===============================================================
        // 🟢 LOGIN (GET)
        // ===============================================================
        public IActionResult Login()
        {
            // Simply loads the login form (Login.cshtml)
            return View();
        }

        // ===============================================================
        // 🟢 LOGIN (POST)
        // ===============================================================
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // Checks if all form fields are valid (email/password required etc.)
            if (ModelState.IsValid)
            {
                // 🔑 Tries to sign in the user using their email & password
                var result = await signInManager.PasswordSignInAsync(
                    model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {
                    // ✅ If login successful → redirect to Home page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // ❌ If login fails → show error message
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
                    return View(model);
                }
            }
            // If validation fails, reload the form with current data
            return View(model);
        }

        // ===============================================================
        // 🟣 REGISTER (GET)
        // ===============================================================
        public IActionResult Register()
        {
            // Loads the registration form (Register.cshtml)
            return View();
        }

        // ===============================================================
        // 🟣 REGISTER (POST)
        // ===============================================================
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // 🆕 Create new user object with entered details
                Users users = new Users()
                {
                    FullName = model.Name,
                    Email = model.Email,
                    UserName = model.Email, // Username = Email (simpler)
                };

                // Creates the user and hashes the password
                var result = await userManager.CreateAsync(users, model.Password);

                if (result.Succeeded)
                {
                    // ✅ Registration successful → redirect to Login
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    // ❌ If errors occur (like weak password) → show them
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
            }
            return View(model);
        }

        // ===============================================================
        // 🟠 VERIFY EMAIL (Forgot Password Step 1)
        // ===============================================================
        public IActionResult VerifyEmail()
        {
            // Displays the email verification form
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> VerifyEmail(VerifyEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                // 🔍 Find the user by entered email
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    // ❌ If email not found
                    ModelState.AddModelError(string.Empty, "Something went wrong.");
                    return View(model);
                }
                else
                {
                    // ✅ If found → go to Change Password page with username
                    return RedirectToAction("ChangePassword", "Account", new { username = user.UserName });
                }
            }
            return View(model);
        }

        // ===============================================================
        // 🔵 CHANGE PASSWORD (Forgot Password Step 2)
        // ===============================================================
        public IActionResult ChangePassword(string username)
        {
            // If username missing, redirect back to VerifyEmail page
            if (string.IsNullOrEmpty(username))
            {
                return RedirectToAction("VerifyEmail", "Account");
            }

            // Pre-fills the form with the user’s email
            return View(new ChangePasswordViewModel { Email = username });
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Finds the user
                var user = await userManager.FindByEmailAsync(model.Email);
                if (user != null)
                {
                    // Removes the old password first
                    var result = await userManager.RemovePasswordAsync(user);

                    if (result.Succeeded)
                    {
                        // Adds the new password
                        result = await userManager.AddPasswordAsync(user, model.NewPassword);

                        // ✅ Redirect to Login after successful password change
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {
                        // Shows validation errors if any
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email not Found");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Something went wrong. Try again.");
                return View(model);
            }
        }

        // ===============================================================
        // 🔴 LOGOUT
        // ===============================================================
        public async Task<IActionResult> Logout()
        {
            // Signs the user out
            await signInManager.SignOutAsync();

            // Redirects to Home page
            return RedirectToAction("Index", "Home");
        }
    }
}
