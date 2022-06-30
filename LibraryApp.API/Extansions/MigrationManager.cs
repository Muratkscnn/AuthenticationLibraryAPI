using LibraryApp.DAL.Concreate.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Extansions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var miniShopContext = scope.ServiceProvider.GetRequiredService<LibraryContext>())
                {
                    try
                    {
                        miniShopContext.Database.Migrate();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return host;
        }

    }
}
