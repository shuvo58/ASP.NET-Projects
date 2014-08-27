using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security.Provider;
using WebMdApp_02.Models;

namespace WebMdApp_02.Controllers
{
    public class ArticleController : Controller
    {
        private AppContext db = new AppContext();

        // GET: /Article/
        public ActionResult Index()
        {
            var articles = db.Articles.Include(a => a.Doctor);
            return View(articles.ToList());
        }



        [HttpPost]
        public ActionResult Index(string text)
        {
            var matchedArticle = db.Articles.Where(a => a.Title.Contains(text)).ToString();
           
            //Doctor aDoctor = db.Doctors.Find(article.DoctorId);
            //ViewBag.NameOfDoctor = aDoctor.Doctorname;
            return View(matchedArticle);
        }


        ////[HttpPost]
        //public ActionResult Index(List<Article> list )
        //{
        //    //var matchedArticle = db.Articles.Where(a => a.DoctorId==id).ToList();
        //    return View(list);
        //}



        // GET: /Article/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        //------------------------------------------------------------------------------------------------

        public ActionResult Post(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            Doctor aDoctor = db.Doctors.Find(article.DoctorId);
            ViewBag.NameOfDoctor = aDoctor.DoctorName;
            //int doctorId = db.Articles.Where(a=>a.DoctorId==)
            return View(article);
        }








        // GET: /Article/Create
        public ActionResult Create()
        {
            ViewBag.DoctorId = new SelectList(db.Doctors, "DoctorId", "DoctorName");
            return View();
        }

        // POST: /Article/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ArticleId,Title,Content,ImagePath,DoctorId")] Article article,HttpPostedFileBase imageFile)
        {
            if (ModelState.IsValid)
            {
                if (imageFile!=null)
                {
                    imageFile.SaveAs(Path.Combine(Server.MapPath("~/images/"), imageFile.FileName));
                    article.ImagePath = imageFile.FileName;
                }
                
                db.Articles.Add(article);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DoctorId = new SelectList(db.Doctors, "DoctorId", "DoctorName", article.DoctorId);
            return View(article);
        }

        // GET: /Article/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            ViewBag.DoctorId = new SelectList(db.Doctors, "DoctorId", "DoctorName", article.DoctorId);
            return View(article);
        }

        // POST: /Article/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ArticleId,Title,Content,ImagePath,DoctorId")] Article article)
        {
            if (ModelState.IsValid)
            {
                db.Entry(article).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DoctorId = new SelectList(db.Doctors, "DoctorId", "DoctorName", article.DoctorId);
            return View(article);
        }

        // GET: /Article/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Article article = db.Articles.Find(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View(article);
        }

        // POST: /Article/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Article article = db.Articles.Find(id);
            db.Articles.Remove(article);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        //public ActionResult Article_by(int? id)
        //{
        //    var matchedArticle = db.Articles.Where(a => a.DoctorId == id).ToList();
        //    return View(matchedArticle);

        //}
    }
}
