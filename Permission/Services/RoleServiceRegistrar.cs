using Microsoft.Extensions.DependencyInjection;
using Permissions.Filters;
using Permissions.Interfaces;
using Permissions.Repositories;

namespace Permissions.Services
{
    public static class RoleServiceRegistrar
    {
        public static IServiceCollection RegisterRoleServices(this IServiceCollection services)
        {
            // Register the Repos
            services.AddTransient<IRoleRepository, RoleRepository>();

            services.AddTransient<IRoleVerificationRepository, RoleVerificationRepository>();
            services.AddScoped<RoleVerificationFilter>();

            return services;
        }
    }
}
