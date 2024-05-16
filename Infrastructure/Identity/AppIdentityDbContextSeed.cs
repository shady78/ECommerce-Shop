using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Shady",
                    Email = "shady@test.com",
                    UserName = "shady@test.com",
                    Address = new Address
                    {
                        FirstName = "Shady",
                        LastName = "Kh",
                        City = "Beni suef",
                        Street = "Shady Street",
                        Zipcode = "12345",
                        State = "Egypt"
                    }
                };
                await userManager.CreateAsync(user, "P@$$w0rd");
            }
        }
    }
}