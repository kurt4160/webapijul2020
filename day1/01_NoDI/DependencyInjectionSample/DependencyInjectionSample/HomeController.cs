using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionSample
{
    public class HomeController
    {
        public string Index(string name)
        {
            var service = new HelloService();
            string result = service.Greet(name);
            return result.ToUpper();
        }
    }
}
