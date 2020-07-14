using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            var response = await _httpClient.GetAsync("https://localhost:5001/api/Books"); // .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            string json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);
            //var task1 = _httpClient.GetAsync("https://localhost:5001/api/Books");
            //task1.ContinueWith(t1 =>
            //{

            //});

        }
    }
}
