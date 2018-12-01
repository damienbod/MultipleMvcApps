using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcApp1.Models;

namespace MvcApp1
{
    public static class ServicesExtensions
    {
        public static void AddMvcApp1(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ExampleService>();

            services.AddDbContext<SomeDataContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("SomeDataContext")));
        }
    }
}
