using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Gym.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; }
    }
}