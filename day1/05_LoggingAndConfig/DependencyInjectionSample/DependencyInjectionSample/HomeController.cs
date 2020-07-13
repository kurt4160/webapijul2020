using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class GreetingOptions
    {
        public string From { get; set; }
    }

    public class HomeController
    {
        private readonly IHelloService _helloService;
        private readonly ILogger _logger;
        private readonly string _from;

        public HomeController(
            IHelloService helloService,
            IOptions<GreetingOptions> options,
            ILogger<HomeController> logger)
        {
            _helloService = helloService;
            _logger = logger;
            _from = options.Value.From;
        }

        public string Index(string name)
        {
            _logger.LogInformation("Index called {name}", name);
            string result = $"{_helloService.Greet(name)} from {_from}";
            return result.ToUpper();
        }
    }
}
