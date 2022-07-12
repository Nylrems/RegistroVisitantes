using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RegistroDeVisitantes.Models;

namespace RegistroDeVisitantes.Controllers
{
    public class VisitantesController : Controller
    {
        private EFEntities db = new EFEntities();

        // GET: Visitantes
        public ActionResult Index()
        {
            return View(db.visitantes.ToList());
        }

        // GET: Visitantes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitantes visitantes = db.visitantes.Find(id);
            if (visitantes == null)
            {
                return HttpNotFound();
            }
            return View(visitantes);
        }

        // GET: Visitantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VisitanteID,Nombres,Apellidos,fechaVisita")] Visitantes visitantes)
        {
            if (ModelState.IsValid)
            {
                db.visitantes.Add(visitantes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(visitantes);
        }

        // GET: Visitantes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitantes visitantes = db.visitantes.Find(id);
            if (visitantes == null)
            {
                return HttpNotFound();
            }
            return View(visitantes);
        }

        // POST: Visitantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VisitanteID,Nombres,Apellidos,fechaVisita")] Visitantes visitantes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(visitantes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(visitantes);
        }

        // GET: Visitantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Visitantes visitantes = db.visitantes.Find(id);
            if (visitantes == null)
            {
                return HttpNotFound();
            }
            return View(visitantes);
        }

        // POST: Visitantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Visitantes visitantes = db.visitantes.Find(id);
            db.visitantes.Remove(visitantes);
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
