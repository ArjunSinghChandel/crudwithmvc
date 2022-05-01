using crudwithmvc.data;
using crudwithmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudwithmvc.Controllers
{
    public class applicationController : Controller
    {
        private readonly applicationdbcontext context;

        public applicationController()
        {
            context = new applicationdbcontext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: application
        public ActionResult Index()
        {
            var studentlist = context.students.ToList();
            return View(studentlist);
        }

        public ActionResult Create()
        {
            student st = new student();
            return View(st);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(student st)
        {
            if (st == null)
                return HttpNotFound();
            context.students.Add(st);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var stud = context.students.Find(id);
            if (stud == null)
                return HttpNotFound();
            return View(stud);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(student st)
        {
            var studfrom = context.students.Find(st.Id);
            if (studfrom == null)
                return HttpNotFound();
            studfrom.Name = st.Name;
            studfrom.Address = st.Address;
            studfrom.email = st.email;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var stud = context.students.Find(id);
            if (stud == null)
                return HttpNotFound();
            return View(stud);

        }
        public ActionResult Delete(int id)
        {
            var stud = context.students.Find(id);
            if (stud == null)
                return HttpNotFound();
            return View(stud);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Delete(student st)
        {
            var stud = context.students.Find(st.Id);
            if (stud == null)
                return HttpNotFound();
            context.students.Remove(stud);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}