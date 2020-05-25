using MVC1.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers
{  
    public class StudentController : Controller
    {
       
        // GET: Student
        public ActionResult Index()
        {
          // MvcApplication.studentsList.Clear();

          // MvcApplication.studentsList.Add(new Models.Student { StudentId = 1, StudentName = "Dan", Age = 18 });
          // MvcApplication.studentsList.Add(new Models.Student { StudentId = 2, StudentName = "Calin", Age = 28 });

            return View(MvcApplication.studentsList);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            var std = MvcApplication.studentsList.Where(s => s.StudentId == id).FirstOrDefault();

            return View(std);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(MVC1.Models.Student student)
        {
            try
            {
                student.StudentId = ++MvcApplication.globalStudentId;
                MvcApplication.studentsList.Add(student);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            var std = MvcApplication.studentsList.Where(s => s.StudentId == id).FirstOrDefault();

            return View(std);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MVC1.Models.Student student)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var std = MvcApplication.studentsList.Where(s => s.StudentId == id).FirstOrDefault();
                    std.Age = student.Age;
                    std.StudentName = student.StudentName;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var std = MvcApplication.studentsList.Where(s => s.StudentId == id).FirstOrDefault();
            return View(std);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var std = MvcApplication.studentsList.Where(s => s.StudentId == id).FirstOrDefault();
                MvcApplication.studentsList.Remove(std);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
