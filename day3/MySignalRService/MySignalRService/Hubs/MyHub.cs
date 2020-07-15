using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySignalRService.Hubs
{
    public class SomeData
    {
        public int Value { get; set; }

        public override string ToString() => Value.ToString();
    }

    public class MyHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public async Task SomeMessage(string user, string message)
        {
            await base.Clients.All.SendAsync("Broadcast", user, message);
        }

        public async IAsyncEnumerable<SomeData> GetSomeDataWithAsyncStreams(int count, int delay)
        {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(delay);
                yield return new SomeData { Value = i };
            }
        }
    }
}
