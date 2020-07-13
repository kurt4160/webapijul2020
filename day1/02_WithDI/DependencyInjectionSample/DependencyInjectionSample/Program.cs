using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new HelloService();
            var controller = new HomeController(service);
            string result = controller.Index("Matthias");
            Console.WriteLine(result);
        }
    }
}
