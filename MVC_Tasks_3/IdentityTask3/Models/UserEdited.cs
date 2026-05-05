using Microsoft.AspNetCore.Identity;

namespace IdentityTask3.Models
{
    public class UserEdited : IdentityUser
    {
        public int Age { get; set; }
    }
}
