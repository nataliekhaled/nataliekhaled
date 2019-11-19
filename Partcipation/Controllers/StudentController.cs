using Partcipation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Partcipation.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student natalie = new Student()
            {
                FirstName = "Natalie",
                LastName = "Khaled",
                StudentID = 5,
                FavoriteColor = "cyan"

            };

            Student hannah = new Student()
            {
                FirstName = "Hannah",
                LastName = "A",
                StudentID = 3,
                FavoriteColor = "purple"

            };
            List<Student> students = new List<Student>();
            students.Add(natalie);
            students.Add(hannah);





            return View();
        }

       
        }
    }

