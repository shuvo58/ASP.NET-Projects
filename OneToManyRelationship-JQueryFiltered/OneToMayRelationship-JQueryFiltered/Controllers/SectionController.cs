using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OneToMayRelationship_JQueryFiltered.Models;

namespace OneToMayRelationship_JQueryFiltered.Controllers
{
    public class SectionController : Controller
    {
        private DepartmentEntities db = new DepartmentEntities();
        //
        // GET: /Section/

        public ViewResult Index(int? departmentId)
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code");

            if (departmentId != null)
            {
                return View(db.Sections.Include(s => s.Department).Where(s => s.Department.DepartmentId == departmentId));
            }
            else
            {
                return View(db.Sections.Include(s => s.Department));
            }
        }

        public PartialViewResult FilteredSection(int? departmentId)
        {
            if (departmentId != null)
            {
                var model = db.Sections.Include(s => s.Department).Where(s => s.Department.DepartmentId == departmentId);
                return PartialView("~/Views/Shared/_FilteredSection.cshtml", model);
            }
            else
            {
                return PartialView("~/Views/Shared/_FilteredSection.cshtml", db.Sections.Include(s => s.Department));
            }
        }

        //
        // GET: /Section/Details/5

        public ActionResult Details(int id = 0)
        {
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            return View(section);
        }

        //
        // GET: /Section/Create

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code");
            return View();
        }

        //
        // POST: /Section/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Section section)
        {
            if (ModelState.IsValid)
            {
                db.Sections.Add(section);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", section.DepartmentId);
            return View(section);
        }

        //
        // GET: /Section/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", section.DepartmentId);
            return View(section);
        }

        //
        // POST: /Section/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Section section)
        {
            if (ModelState.IsValid)
            {
                db.Entry(section).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "Code", section.DepartmentId);
            return View(section);
        }

        //
        // GET: /Section/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Section section = db.Sections.Find(id);
            if (section == null)
            {
                return HttpNotFound();
            }
            return View(section);
        }

        //
        // POST: /Section/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Section section = db.Sections.Find(id);
            db.Sections.Remove(section);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}