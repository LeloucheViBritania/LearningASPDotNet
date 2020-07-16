using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamikTemplateGrp.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Courses()
        {
            return View();
        }
    }
}