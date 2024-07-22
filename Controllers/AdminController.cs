using Microsoft.AspNetCore.Mvc;
using SymphonyLtd.Database;
using SymphonyLtd.Models;

namespace SymphonyLtd.Controllers
{
    public class AdminController : Controller
    {
        ApplicationDbContext dc;
        public AdminController(ApplicationDbContext dc)
        {
            this.dc = dc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult courses()
        {
            return View();
        }
        [HttpPost]
        public IActionResult courses(courses crs)
        {
            dc.tblCourses.Add(crs);
            dc.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public IActionResult students()
        {
            return View();
        }
        public IActionResult studdents(students std)
        {
            dc.tblStudents.Add(std);
            dc.SaveChanges();
            ModelState.Clear();
            return View();
        }
        public IActionResult contactdetails()
        {
            return View();
        }
    }
}
