using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BooksMVC.Models;

namespace BooksMVC.Controllers
{
    public class CatalogueController : Controller
    {
        private BookDbContext db = new BookDbContext();

        //
        // GET: /Catalogue/

        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        //
        // GET: /Catalogue/Details/5

        public ActionResult Details(int id = 0)
        {
            Books books = db.Books.Find(id);
            if (books == null)
            {
                return HttpNotFound();
            }
            return View(books);
        }

        //
        // GET: /Catalogue/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Catalogue/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Books books)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(books);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(books);
        }

        //
        // GET: /Catalogue/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Books books = db.Books.Find(id);
            if (books == null)
            {
                return HttpNotFound();
            }
            return View(books);
        }

        //
        // POST: /Catalogue/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Books books)
        {
            if (ModelState.IsValid)
            {
                db.Entry(books).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(books);
        }

        //
        // GET: /Catalogue/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Books books = db.Books.Find(id);
            if (books == null)
            {
                return HttpNotFound();
            }
            return View(books);
        }

        //
        // POST: /Catalogue/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Books books = db.Books.Find(id);
            db.Books.Remove(books);
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