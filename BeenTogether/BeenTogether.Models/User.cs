using Microsoft.AspNetCore.Identity;

namespace BeenTogether.Models
{
    public class User : IdentityUser
    {
        public int BirthYear { get; set; }

        public string? IsInLoveWith { get; set; }

        public virtual ICollection<Love> Loves { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
