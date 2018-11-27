using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MvcApp1
{
    public static class ServicesExtensions
    {
        public static void AddMvcApp1(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ExampleService>();
            //services.Configure<ThemesOptions>(configuration.GetSection("Themes"));
        }
    }
}
