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
            return Content("Response from Courses/Index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Response from Courses/Detail with id = {id}" );
        }
    }
}