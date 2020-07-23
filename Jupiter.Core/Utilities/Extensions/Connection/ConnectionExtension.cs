using Jupiter.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AngularEshop.Core.Utilities.Extensions.Connection
{
    public static class ConnectionExtension
    {

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection service,
          IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options =>
            {
                var connectionString = "ConnectionStrings:SQLServer:Development";
                options.UseSqlServer(configuration[connectionString]);
            });

            return service;
        }

    }
}
