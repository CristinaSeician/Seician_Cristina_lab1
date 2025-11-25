using Microsoft.AspNetCore.Mvc;
using Seician_Cristina_lab1.Models;

namespace Seician_Cristina_lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
        public IActionResult Mesaj() 
        {
            ViewBag.Message = "Mesaj din Controller";
            ViewData["Time"] = DateTime.Now;
            return View();
        }
    }
}
