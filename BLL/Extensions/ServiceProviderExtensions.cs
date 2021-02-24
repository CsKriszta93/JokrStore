using JOKRStore.DAL;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BLL.Extensions
{
    public static class ServiceProviderExtensions
    {
        public static ApplicationDbContext GetDbContext(this IServiceProvider services)
        {
            return services.GetRequiredService<ApplicationDbContext>();
        }
    }
}
