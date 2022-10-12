using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MvcCouche.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcCouche.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCoucheContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCoucheContext>>()))
            {
                // Look for any movies.
                if (context.Couche.Any())
                {
                    return;   // DB has been seeded
                }

                context.Couche.AddRange(
                    new Couche
                    {
                        Price = 5779,
                        Colour="Grey",
                        Height=33,
                        Weight="33 lb",
                        Design="Standard",
                        CountryOfOrigin="America"
                    },
                     new Couche
                     {
                         Price = 1569,
                         Colour = "Midnight Blue",
                         Height = 25,
                         Weight = "99 lb",
                         Design = "Chesterfield",
                         CountryOfOrigin = "China"
                     },
                      new Couche
                      {
                          Price = 1299,
                          Colour = "Aubergine",
                          Height = 33,
                          Weight = "83 lb",
                          Design = "Standard",
                          CountryOfOrigin = "United States"
                      },
                       new Couche
                       {
                           Price = 749,
                           Colour = "Creamr Polyster",
                           Height = 26,
                           Weight = "116 lb",
                           Design = "Standard",
                           CountryOfOrigin = "China"
                       },
                        new Couche
                        {
                            Price = 749,
                            Colour = "Pink Velvet",
                            Height = 25,
                            Weight = "81 lb",
                            Design = "Sofa Bed",
                            CountryOfOrigin = "Italy"
                        },
                         new Couche
                         {
                             Price = 959,
                             Colour = "Green",
                             Height = 25,
                             Weight = "81 lb ",
                             Design = "Convertable",
                             CountryOfOrigin = "Italy"
                         }
                );
                context.SaveChanges();
            }
        }
    }
}
