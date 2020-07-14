using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmptyWebApp.Controllers
{
    class Data
    {
        public string Text { get; set; }
    }

    public class ReturnDataController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("https://csharp.christiannagel.com");
        }

        public IActionResult One()
        {
            var x = new Data { Text = "init" };
            // return Json(x, )
            return Ok(x);
        }

        public IActionResult Two()
        {
            return NotFound();
        }
    }
}
