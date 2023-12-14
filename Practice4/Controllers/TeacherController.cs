using Microsoft.AspNetCore.Mvc;
using Practice4.Models;

namespace Practice4.Controllers
{
    public class TeacherController : Controller
    {

        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mr.Prasath", TeachingSubject = "Physics"},
            new Teacher { Id = 2, Name = "Mr.varun", TeachingSubject = "Biology"},
            new Teacher { Id = 3, Name = "Mr.kavin", TeachingSubject = "Maths"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
