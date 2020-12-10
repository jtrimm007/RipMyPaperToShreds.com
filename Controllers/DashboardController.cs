using Microsoft.AspNetCore.Mvc;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Controllers
{
   
    public class DashboardController : Controller
    {
        private IPapers _paperRepo;

        public DashboardController(IPapers paperRepo)
        {
            _paperRepo = paperRepo;
        }
        public IActionResult Index()
        {
            return View();
        }


    }
}
