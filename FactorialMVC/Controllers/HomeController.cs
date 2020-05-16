using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FactorialMVC.Models;

namespace FactorialMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(Factorial factorial)
        {

            if (ModelState.IsValid)
            {
                List<long> results = new List<long>();

                long fact = 1;

                for (long i = 1; i <= factorial.Number; i++)
                {
                    fact *= i;
                    results.Add(fact);
                }

                ViewBag.value = true;
                ViewBag.resultado = new Factorial() { Number = factorial.Number, Result = fact, Results = results };
            }

            return View();
        }
    }
}
