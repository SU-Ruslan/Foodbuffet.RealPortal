// Models/ApplicationUser.cs
using Microsoft.AspNetCore.Identity;

namespace Foodbuffet.RealPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Добавьте дополнительные свойства, если нужно
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}