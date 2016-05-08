using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MathTeacher.DAL;
using MathTeacher.Models;

namespace MathTeacher.Controllers
{
    public class QuestionController : Controller
    {
        private GameContext db = new GameContext();

        // GET: Question
        public ActionResult Index()
        {
            return View(db.Questions.ToList());
        }

        // GET: Question/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModel questionModel = db.Questions.Find(id);
            if (questionModel == null)
            {
                return HttpNotFound();
            }
            return View(questionModel);
        }

        // GET: Question/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Question/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Grade")] QuestionModel questionModel)
        {
            if (ModelState.IsValid)
            {
                db.Questions.Add(questionModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(questionModel);
        }

        // GET: Question/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModel questionModel = db.Questions.Find(id);
            if (questionModel == null)
            {
                return HttpNotFound();
            }
            return View(questionModel);
        }

        // POST: Question/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Grade")] QuestionModel questionModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(questionModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(questionModel);
        }

        // GET: Question/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuestionModel questionModel = db.Questions.Find(id);
            if (questionModel == null)
            {
                return HttpNotFound();
            }
            return View(questionModel);
        }

        // POST: Question/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QuestionModel questionModel = db.Questions.Find(id);
            db.Questions.Remove(questionModel);
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
