using _29._03hw.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _29._03hw.Controllers
{
    public class StudentController : Controller
    {
        private readonly List<Student> _studnets;
        public StudentController()
        {
            _studnets = new List<Student>
            {
                new Student{Id = 1,FullName = "student1 f1",Point = 97},
                new Student{Id = 2,FullName = "student2 f2",Point = 60},
                new Student{Id = 3,FullName = "student3 f3",Point = 70},
                new Student{Id = 4,FullName = "student4 f4",Point = 90},
            };
        }

        public ActionResult Index()
        {
            ViewBag.Students = _studnets;
            return View();
        }
        public ActionResult Detail(int id)
        {
            Student std = _studnets.Find(x => x.Id == id);
            ViewBag.Student = std;

            return View();
        }

    }
}
