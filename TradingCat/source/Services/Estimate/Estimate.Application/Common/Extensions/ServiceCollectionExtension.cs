using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Estimate.Application.Common.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}