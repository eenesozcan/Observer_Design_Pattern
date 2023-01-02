using Microsoft.AspNetCore.Identity;

namespace Observer_Design_Pattern.DAL
{
    public class AppUser:IdentityUser<int>
    {
        public int Name { get; set; }
        public int Surname { get; set; }
    }
}
