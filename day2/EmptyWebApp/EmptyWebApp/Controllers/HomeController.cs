using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmptyWebApp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Foo";
        }

        public int Add(int x, int y) => x + y;

        public int Subtract(int x, int y) => x - y;

    }
}
