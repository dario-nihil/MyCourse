using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controller
{
    public class HomeController : ControllerBase
    {
        public IActionResult Index()
        {
            return Content("Response from Home/index");
        }
    }
}