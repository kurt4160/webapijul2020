using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public static class HomeControllerExtensions
    {
        public static IServiceCollection AddHomeController(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<GreetingOptions>(configuration);
            return services.AddTransient<HomeController>();
        }
    }
}
