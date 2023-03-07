using Microsoft.AspNetCore.Identity;

namespace IdeaSystem.Entities
{
    public class Role : IdentityRole
    {
        public bool role_IsDelete { get; set; }
    }
}
