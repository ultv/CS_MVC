using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class StudentController : Controller
    {
        Student db = new Student();

        public ViewResult Catalog()
        {
            
            /*
            Student student1 = new Student() {FirstName = "Александр", SurName = "Седов", Age = 21, Faculty = "ФИСТ"};
            Student student2 = new Student() { FirstName = "Юрий", SurName = "Кузнецов", Age = 19, Faculty = "ФИСТ" };

            db.Students.Add(student1);
            db.Students.Add(student2);
            db.SaveChanges();
            */

            // Получаем данные из базы.
            IEnumerable<Student> Students = db.Students;
            ViewBag.Students = Students;
            
            return View();
        }

        public ViewResult Registrate()
        {
            
            // Получаем данные из базы.
            IEnumerable<Student> Students = db.Students;
            ViewBag.Students = Students;

            return View();
        }


        public ActionResult Added(Student student)
        {

            db.Students.Add(student);
            db.SaveChanges();

            return Redirect("/Student/Catalog");
        }


        public ActionResult Delete(int id)
        {

            Student student = db.Students.Find(id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return  Redirect("/Student/Catalog");
        }
    }
}