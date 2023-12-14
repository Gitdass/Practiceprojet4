using Microsoft.AspNetCore.Mvc;
using Practice4.Models;

namespace Practice4.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "dass", Class = "9A", Age = 15, Address = "12 Abc street"},
            new Student { Id = 2, Name = "vijay", Class = "10B", Age = 16, Address = "15 bell Street"},
            new Student { Id = 3, Name = "vino", Class = "8A", Age = 14, Address = "567 paris street"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}