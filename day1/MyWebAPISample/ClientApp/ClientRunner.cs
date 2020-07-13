using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class ClientRunner
    {
        private readonly HttpClient _httpClient;

        public ClientRunner(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task ShowBooksAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:5001/api/Books");
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
        }
    }
}
