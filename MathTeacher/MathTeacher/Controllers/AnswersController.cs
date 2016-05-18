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
    public class AnswersController : Controller
    {
        private GameContext db = new GameContext();

        // GET: Answers/Review/5
        public ActionResult Review(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }

        // GET: Answers/Give/5
        [Authorize]
        public ActionResult Give(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }

        // POST: Answers/Give/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Give([Bind(Include = "ID,StartTime,EndTIme,Result")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                Answer dbanswer = db.Answers.Find(answer.ID);

                dbanswer.Result = answer.Result;
                dbanswer.EndTIme = DateTime.Now;
                dbanswer.IsAnswered = true;

                db.SaveChanges();
                
                var next = dbanswer.Next();
            
                  return RedirectToAction("Review",new { id = dbanswer.ID });
                
               
              
                  
               
               
            }
            return View(answer);
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
