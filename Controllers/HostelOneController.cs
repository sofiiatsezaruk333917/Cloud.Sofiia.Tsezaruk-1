using HostelNaUOA.Core;
using Microsoft.AspNetCore.Mvc;
using HostelNaUOA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelNaUOA.Controllers
{
    public class HostelOneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Hostel hostel)
        {
            if (!ModelState.IsValid)
            {
                return View(hostel);
            }
            return View(hostel);
        }
    }
}
