using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstEFProject.Models;

namespace FirstEFProject.Controllers
{
    public class BookDetailsController : Controller
    {
        private LibraryDBEntities db = new LibraryDBEntities();

        // GET: BookDetails
        public ActionResult Index()
        {
            return View(db.BookDetails.ToList());
        }

        // GET: BookDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // GET: BookDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookDetails/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BookName,Price,Category,AuthorName,Edition,BookCondition,Available")] BookDetails bookDetails)
        {
            if (ModelState.IsValid)
            {
                db.BookDetails.Add(bookDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookDetails);
        }

        // GET: BookDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // POST: BookDetails/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BookName,Price,Category,AuthorName,Edition,BookCondition,Available")] BookDetails bookDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookDetails);
        }

        // GET: BookDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // POST: BookDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookDetails bookDetails = db.BookDetails.Find(id);
            db.BookDetails.Remove(bookDetails);
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
    }
}
