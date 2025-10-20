using Microsoft.AspNetCore.Identity;

namespace M_UserLogin.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
