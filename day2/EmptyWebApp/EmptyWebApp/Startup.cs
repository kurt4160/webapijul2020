using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmptyWebApp.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmptyWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMycustomHeaderMiddleware();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");

                endpoints.MapControllerRoute(
                                   name: "calc",
                                   pattern: "{controller=Home}/{action=Add}/{x}/{y}");

                endpoints.MapGet("/", async context =>
                {
                   
                    await context.Response.WriteAsync("<h1>Hello World!</h1>");
                });
            });
        }
    }
}
