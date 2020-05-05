using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetMiddlewares.RouteLifetime
{
    public static class RouteLifetimeExtensions
    {
        public static IServiceCollection AddRouteLifetime(this IServiceCollection services)
        {
            services.TryAddSingleton<RouteLifetimeMiddleware, RouteLifetimeMiddleware>();
            services.TryAddSingleton<ILifetimeRepository, LifetimeRepository>();
            
            return services;
        }

        public static IApplicationBuilder UseRouteLifetime(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RouteLifetimeMiddleware>();
        }
    }
}
