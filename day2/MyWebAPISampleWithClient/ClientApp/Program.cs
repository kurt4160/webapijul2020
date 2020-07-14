using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {


            Console.WriteLine("client - wait for service");
            Console.ReadLine();

            using var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddHttpClient<ClientRunner>("books", options =>
                    {

                        options.BaseAddress = new Uri("https://localhost:5001");
                    }).AddTypedClient<ClientRunner>();
                })
                .Build();


            var runner = host.Services.GetService<ClientRunner>();
            await runner.ShowBooksAsync();

           
        }
    }
}
