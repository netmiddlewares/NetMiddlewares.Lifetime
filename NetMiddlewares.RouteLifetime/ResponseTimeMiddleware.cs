using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace NetMiddlewares.RouteLifetime
{
    public class RouteLifetimeMiddleware : IMiddleware
    {
        private readonly ILifetimeRepository _lifetimeRepository;

        public RouteLifetimeMiddleware(ILifetimeRepository lifetimeRepository)
        {
            _lifetimeRepository = lifetimeRepository;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            _lifetimeRepository.AddEntry(context.Request.Path);

            context.Response.OnStarting(() =>
            {
                return Task.CompletedTask;
            });

            await next(context);
        }
    }
}
