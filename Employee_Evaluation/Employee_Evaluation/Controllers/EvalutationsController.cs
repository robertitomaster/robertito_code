using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Employee_Evaluation;
using Employee_Evaluation.Models;

namespace Employee_Evaluation.Controllers
{
    public class EvalutationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Evalutations
        public ActionResult Index()
        {
            return View(db.Evalutations.ToList());
        }

        // GET: Evalutations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evalutation evalutation = db.Evalutations.Find(id);
            if (evalutation == null)
            {
                return HttpNotFound();
            }
            return View(evalutation);
        }

        // GET: Evalutations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Evalutations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EvaluationId,EvalutaionTitle,Objectives,Accomplishments,EmployeeComments,ManagerComments")] Evalutation evalutation)
        {
            if (ModelState.IsValid)
            {
                db.Evalutations.Add(evalutation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evalutation);
        }

        // GET: Evalutations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evalutation evalutation = db.Evalutations.Find(id);
            if (evalutation == null)
            {
                return HttpNotFound();
            }
            return View(evalutation);
        }

        // POST: Evalutations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EvaluationId,EvalutaionTitle,Objectives,Accomplishments,EmployeeComments,ManagerComments")] Evalutation evalutation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(evalutation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(evalutation);
        }

        // GET: Evalutations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evalutation evalutation = db.Evalutations.Find(id);
            if (evalutation == null)
            {
                return HttpNotFound();
            }
            return View(evalutation);
        }

        // POST: Evalutations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Evalutation evalutation = db.Evalutations.Find(id);
            db.Evalutations.Remove(evalutation);
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
