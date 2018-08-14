using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.DataAccessLayer;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NotepadController : Controller
    {
        private NotePadContext db = new NotePadContext();

        // GET: Notepad
        public ActionResult Index()
        {
            return View(db.NotePad.ToList());
        }

        // GET: Notepad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.NotePad.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            return View(notepad);
        }

        // GET: Notepad/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Notepad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Task")] Notepad notepad)
        {
            if (ModelState.IsValid)
            {
                db.NotePad.Add(notepad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notepad);
        }

        // GET: Notepad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.NotePad.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            return View(notepad);
        }

        // POST: Notepad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Task")] Notepad notepad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notepad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notepad);
        }

        // GET: Notepad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.NotePad.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            return View(notepad);
        }

        // POST: Notepad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Notepad notepad = db.NotePad.Find(id);
            db.NotePad.Remove(notepad);
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
