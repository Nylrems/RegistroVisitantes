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
    public class HistorialVisitasController : Controller
    {
        private EFEntities db = new EFEntities();

        // GET: HistorialVisitas
        public ActionResult Index()
        {
            return View(db.HistorialVisitas.ToList());
        }

        // GET: HistorialVisitas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistorialVisitas historialVisitas = db.HistorialVisitas.Find(id);
            if (historialVisitas == null)
            {
                return HttpNotFound();
            }
            return View(historialVisitas);
        }

        // GET: HistorialVisitas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HistorialVisitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HistorialId,HoraDeEntrada,HoraDeSalida,VisitanteId")] HistorialVisitas historialVisitas)
        {
            if (ModelState.IsValid)
            {
                db.HistorialVisitas.Add(historialVisitas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(historialVisitas);
        }

        // GET: HistorialVisitas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistorialVisitas historialVisitas = db.HistorialVisitas.Find(id);
            if (historialVisitas == null)
            {
                return HttpNotFound();
            }
            return View(historialVisitas);
        }

        // POST: HistorialVisitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HistorialId,HoraDeEntrada,HoraDeSalida,VisitanteId")] HistorialVisitas historialVisitas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historialVisitas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(historialVisitas);
        }

        // GET: HistorialVisitas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistorialVisitas historialVisitas = db.HistorialVisitas.Find(id);
            if (historialVisitas == null)
            {
                return HttpNotFound();
            }
            return View(historialVisitas);
        }

        // POST: HistorialVisitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistorialVisitas historialVisitas = db.HistorialVisitas.Find(id);
            db.HistorialVisitas.Remove(historialVisitas);
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
