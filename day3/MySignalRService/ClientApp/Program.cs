using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace ClientApp
{
    public class SomeData
    {
        public int Value { get; set; }

        public override string ToString() => Value.ToString();
    }

    class Program
    {
        private static HubConnection? s_hubConnection;
        static async Task Main()
        {
            Console.WriteLine("client - wait for service...");
            Console.ReadLine();

            await ServerToClientStreamingAsync();
            // await ClientToServerStreamingAsync();
        }

        private static async Task ServerToClientStreamingAsync()
        {
            s_hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:5001/myhub")
                .Build();

            s_hubConnection.Closed += async (ex) =>
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("restart");
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await s_hubConnection.StartAsync();
            };

            await s_hubConnection.StartAsync();

            // read from the hub using async streams
            var stream = s_hubConnection.StreamAsync<SomeData>("GetSomeDataWithAsyncStreams", 20, 1000);
            await foreach (var d in stream)
            {
                Console.WriteLine($"received {d}");
            }

            // https://github.com/aspnet/AspNetCore.Docs/blob/master/aspnetcore/signalr/streaming.md
        }
    }
}
