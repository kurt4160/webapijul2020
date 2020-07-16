using Grpc.Net.Client;
using MyGRPCService;
using System;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            Greeter.GreeterClient client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(new HelloRequest { Name = "Matthias" });
            Console.WriteLine(reply.Message);
        }
    }
}
