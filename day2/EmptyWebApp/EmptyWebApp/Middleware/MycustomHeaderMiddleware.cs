using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace EmptyWebApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MycustomHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public MycustomHeaderMiddleware(RequestDelegate next, ILogger<MycustomHeaderMiddleware> logger)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("myheader", "my value");
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MycustomHeaderMiddlewareExtensions
    {
        public static IApplicationBuilder UseMycustomHeaderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MycustomHeaderMiddleware>();
        }
    }
}
