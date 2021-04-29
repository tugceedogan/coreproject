using CoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject.Controllers
{
    public class CourseController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "good afternon " : "good morning";
            return View("MyView");
        }

        public ViewResult List()
        {
            var liste=Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);

            }
            else
            {
                return View();

            }
            //Model binding
            //student bilgisini vt nına kaydet.
            //sanal vt oluştur ve kayıt et.

        }
    }
}
