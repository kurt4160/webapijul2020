using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Azure.Functions;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MyAPIWithAzureFunction;

[assembly: FunctionsStartup(typeof(Startup))]

namespace MyAPIWithAzureFunction
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddTransient<INameService, NameService>();
        }
    }
}
