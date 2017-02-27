using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public async Task<IActionResult> Contact()
        {
            using (var client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://webapplication2/api/values");

                ViewData["Message"] = result;
            }

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
