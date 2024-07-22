using Microsoft.AspNetCore.Mvc;
using SymphonyLtd.Database;
using SymphonyLtd.Models;

namespace SymphonyLtd.Controllers
{
    public class WebController : Controller
    {
        ApplicationDbContext dc;
        public WebController(ApplicationDbContext dc) 
        {
            this.dc = dc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult courses()
        {
            return View();
        }
        public IActionResult exam()
        {
            return View();
        }
        public IActionResult faqs()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }

        public IActionResult contactInfo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult contactInfo(contact c)
        {
            dc.tblContact.Add(c);
            dc.SaveChanges();
            ModelState.Clear();
            return View();
        }
        
    }
}
