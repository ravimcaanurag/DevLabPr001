using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevLab002.Controllers
{
    public class FisrtController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
