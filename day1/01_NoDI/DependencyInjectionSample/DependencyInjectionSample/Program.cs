using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new HomeController();
            string result = controller.Index("Stephanie");
            Console.WriteLine(result);
        }
    }
}
