using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RipMyPaperToShreds.com.Models;

namespace RipMyPaperToShreds.com.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Papers()
        {
            return View();
        }

        public async Task<IActionResult> Papers(List<string> hashTags)
        {
            return View();
        }

        public async Task<IActionResult> Papers(string tagsOrTitle)
        {
            return View();
        }

        public async Task<IActionResult> Papers(List<string> hashTags, string title)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
