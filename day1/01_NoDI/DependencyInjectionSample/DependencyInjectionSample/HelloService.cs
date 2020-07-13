using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class HelloService
    {
        public string Greet(string name) => $"Hello, {name}";
    }
}
