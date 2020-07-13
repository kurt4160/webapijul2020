using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class HelloService : IHelloService
    {
        private readonly ILogger _logger;
        public HelloService(ILogger<HelloService> logger)
        {
            _logger = logger;
        }
        public string Greet(string name)
        {
            _logger.LogError("sample error in Greet");
            return $"Hello, {name}";
        }
    }
}
