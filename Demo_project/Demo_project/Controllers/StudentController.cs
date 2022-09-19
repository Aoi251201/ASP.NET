using Demo_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_project.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //Student student1 = new Student("0", "Nguyễn Văn A", 20);
            List<Student> listStudent = new List<Student>()
            {
                new Student("0", "Nguyễn Văn A", 18),
                new Student("1", "Nguyễn Văn B", 19),
                new Student("2", "Nguyễn Văn C", 20),
                new Student("3", "Nguyễn Văn D", 21),
                new Student("4", "Nguyễn Văn E", 22)
            };

            //listStudent.Add(student);
            ViewData["Student"] = listStudent;

            return View();
        }
        public IActionResult Create(Student student)
        {
            
            ViewData["Info"] = student.ID + "   " + student.Name + "   " + student.Age;
            
            
            return View();
        }
    }
}
