using ContactList.Data.Data.Context;
using ContactList.Data.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Data.Data.Intitializer
{
    public class AppInitializer
    {
        public static async Task Seed(IApplicationBuilder applicationBuilder)
        {
            
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.ContactList.Any())
                {
                    context.ContactList.AddRange(
                            new UserContactList()
                            {
                                Name =  "Rodger Ferguson",
                                About = "Self motivated...",
                                Avatar = 11,
                                Phone = "+38(97)123-45-67",
                                Gender = "men",
                                Favorite = true,
                                Position = ".NET Developer"
                            },
                             new UserContactList()
                             {
                                 Name = "Eva Anderson",
                                 About = "Best UI/UX designer...",
                                 Avatar = 51,
                                 Phone = "+38(97)423-45-41",
                                 Gender = "women",
                                 Favorite = true,
                                 Position = "UI/UX designer"
                             },
                              new UserContactList()
                              {
                                  Name = "Edward Tomson",
                                  About = "A'm a best PM...",
                                  Avatar = 93,
                                  Phone = "+38(63)652-45-41",
                                  Gender = "women",
                                  Favorite = false,
                                  Position = "Project manager"
                              }
                        );
                    await context.SaveChangesAsync();
                }
               
            }
        }
    }
}
