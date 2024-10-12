using Microsoft.AspNetCore.Mvc;
using WBL_MVC_Lesson.Models;

namespace WBL_MVC_Lesson.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult MyFirstIndex()
        //{
        //    Student student = new Student()
        //    {
        //        Id = 1,
        //        Name = "Nigar",
        //        Surname = "Məmmədova"
        //    };

        //    return View(student);
        //}

        public IActionResult MyFirstIndex()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=1, Name="Nigar",Surname="Məmmədova"},
                new Student(){Id=2, Name="Mədinə",Surname="Əlizadə"},
                new Student(){Id=3, Name="Aysu",Surname="Cəbrayılova"},
            };

            return View(students);
        }
    }
}
