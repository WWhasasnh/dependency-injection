using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Areas.SudentsReports.Controllers
{
    public class StudentsReports2Controller : Controller
    {
        // GET: SudentsReports/StudentsReports
        public ActionResult StudentsAttendance()
        {
            return View();
        }
    }
}