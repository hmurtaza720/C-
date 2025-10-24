// Import Identity namespace — gives access to built-in Identity classes like IdentityUser
using Microsoft.AspNetCore.Identity;

namespace M_UserLogin.Models
{
    // 🧍‍♂️ This 'Users' class represents each user in your system.
    // It inherits from 'IdentityUser', which already contains common user properties like:
    //  - Id (unique user ID)
    //  - UserName
    //  - Email
    //  - PasswordHash
    //  - PhoneNumber
    //  - Lockout settings, etc.

    public class Users : IdentityUser
    {
        // 🧩 Custom field you added to store the full name of the user
        // (ASP.NET Identity by default doesn't include 'FullName', so you extend it here)
        public string FullName { get; set; }
    }
}
