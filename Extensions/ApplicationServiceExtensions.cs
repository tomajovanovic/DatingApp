using DateApp.Data;
using DateApp.Interfaces;
using DateApp.Services;
using Microsoft.EntityFrameworkCore;

namespace DateApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt =>
                {
                    opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
                }); // ja dodao ovo

            services.AddCors();

            services.AddScoped<ITokenService, TokenService>(); // moze i singleton ali nema potrebe da stoji u memoriji sve vreme, moze i transient ali je prekratko

            return services;
        }
    }
}