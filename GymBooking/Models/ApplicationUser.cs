using Microsoft.AspNetCore.Identity;

namespace GymBooking.Models
{
    public class ApplicationUser: IdentityUser
    {
        #nullable disable
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName => @"{FirstName} {LastName}";
        DateTime TimeOfRegistration { get; set; }
        public ICollection<ApplicationUserGymClass> AttendedClasses { get; set; } = new List<ApplicationUserGymClass>();
    }
}
