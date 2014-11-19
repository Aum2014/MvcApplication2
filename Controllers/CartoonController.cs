using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class CartoonController : Controller
    {
        private CartoonDBContext db = new CartoonDBContext();

        //
        // GET: /Cartoon/

        public ActionResult Index()
        {
            return View(db.Cartoon.ToList());
        }

        //
        // GET: /Cartoon/Details/5

        public ActionResult Details(int id = 0)
        {
            Cartoon cartoon = db.Cartoon.Find(id);
            if (cartoon == null)
            {
                return HttpNotFound();
            }
            return View(cartoon);
        }

        //
        // GET: /Cartoon/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cartoon/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cartoon cartoon)
        {
            if (ModelState.IsValid)
            {
                db.Cartoon.Add(cartoon);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartoon);
        }

        //
        // GET: /Cartoon/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cartoon cartoon = db.Cartoon.Find(id);
            if (cartoon == null)
            {
                return HttpNotFound();
            }
            return View(cartoon);
        }

        //
        // POST: /Cartoon/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cartoon cartoon)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartoon).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartoon);
        }

        //
        // GET: /Cartoon/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cartoon cartoon = db.Cartoon.Find(id);
            if (cartoon == null)
            {
                return HttpNotFound();
            }
            return View(cartoon);
        }

        //
        // POST: /Cartoon/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cartoon cartoon = db.Cartoon.Find(id);
            db.Cartoon.Remove(cartoon);
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