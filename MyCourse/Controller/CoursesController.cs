using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyCourse.Controller
{
    public class CoursesController : ControllerBase
    {
        public IActionResult Index()
        {
            return Content("Response from Details/Index");
        }

        public IActionResult Details(string id)
        {
            return Content($"Response from Courses/Details with id = {id}" );
        }
    }
}