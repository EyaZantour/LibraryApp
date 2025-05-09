using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using LibraryNotebook.Data.Context;
using LibraryNotebook.Data.Repositories;

namespace LibraryNotebook.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLibraryNotebookDataServices(this IServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseSqlite("Data Source=library.db"));

            services.AddScoped<BookRepository>();
            services.AddScoped<StudentRepository>();
            services.AddScoped<IssueRepository>();


            return services;
        }
        public static void ApplyMigrationsForLibraryNotebookDataService(this IServiceProvider provider)
        {
            using (var scope = provider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LibraryContext>();
                db.Database.Migrate(); // Apply any pending migrations
            }
        }
    }
}
