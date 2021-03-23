using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GESECOSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddStudents()
        {
            return View();
        }
        public ActionResult AddTeachers()
        {
            return View();
        }
    }
}