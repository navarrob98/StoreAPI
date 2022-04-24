using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager){
            if(!userManager.Users.Any()){
                var user = new AppUser{
                    DisplayName = "Bob",
                    Email = "bob@test.com",
                    UserName = "bob@test.com",
                    Address = new Address {
                        FirstName = "Bob",
                        LastName = "Bobbity",
                        Street = "1255 Broadway",
                        City = "Chula Vista",
                        State = "California",
                        ZipCode = "91911"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}