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
            var runner = new ClientRunner(new HttpClient());
            await runner.ShowBooksAsync();
        }
    }
}
