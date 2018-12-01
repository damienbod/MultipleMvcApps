using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MvcApp2
{
    public static class ServicesExtensions
    {
        public static void AddMvcApp2(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ExampleService>();
            //services.Configure<ThemesOptions>(configuration.GetSection("Themes"));
        }
    }
}
