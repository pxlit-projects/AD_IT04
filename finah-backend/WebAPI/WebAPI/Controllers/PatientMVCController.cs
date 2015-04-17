using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Dokter")]
    public class PatientMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public PatientMVCController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        public ActionResult Index()
        {
            var currentUser = manager.FindById(User.Identity.GetUserId());

            var dokterId = 0;
            if (currentUser != null)
            {
                dokterId = db.Dokters
                    .Where(r => r.Email == currentUser.Email)
                    .Select(r => r.Id)
                    .FirstOrDefault();
            }

            var model = db.PatientMantelzorgers
                .Where(r => r.Dokter_Id == dokterId && r.Verzorger == false);

            return View(model);
        }

        // GET: PatientMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PatientMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PatientMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WebAPI.Models.PatientMantelzorger patient)
        {
            if (ModelState.IsValid)
            {
                var currentUser = manager.FindById(User.Identity.GetUserId());

                var dokterId = 0;
                if (currentUser != null)
                {
                    dokterId = db.Dokters
                        .Where(r => r.Email == currentUser.Email)
                        .Select(r => r.Id)
                        .FirstOrDefault();
                }

                patient.Verzorger = false;
                patient.Dokter_Id = dokterId;

                db.PatientMantelzorgers.Add(patient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // GET: PatientMVC/Edit
        public ActionResult EditMovie(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            WebAPI.Models.PatientMantelzorger patient = db.PatientMantelzorgers.Find(id);

            if (patient == null)
            {
                return HttpNotFound();
            }

            return View(patient);
        }

        // POST: PatientMVC/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientMantelzorger patient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(patient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(patient);
        }

        // GET: PatientMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PatientMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
