using Microsoft.Extensions.DependencyInjection;
using System;


namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using var container = GetServices();
            var controller = container.GetService<HomeController>();

            string result = controller.Index("Matthias");
            Console.WriteLine(result);
        }

        static ServiceProvider GetServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IHelloService, HelloService>();
            services.AddTransient<HomeController>();
            return services.BuildServiceProvider();
        }
    }
}
