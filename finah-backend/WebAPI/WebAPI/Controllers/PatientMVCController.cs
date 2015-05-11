using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
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
                if (db.Users.Where(r => r.Email == patient.Email).FirstOrDefault() == null)
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

                    var user = new ApplicationUser { UserName = patient.Email, Email = patient.Email };
                    manager.Create(user, "P@ssw0rd");
                    manager.AddToRole(user.Id, "PatientMantelzorger");

                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                return View(patient);
            }

            return View(patient);
        }

        // GET: PatientMVC/Edit
        public ActionResult Edit(int id)
        {
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
        public ActionResult Edit(PatientMantelzorger nieuwePatient)
        {
            PatientMantelzorger oudePatient = db.PatientMantelzorgers.Find(nieuwePatient.Id);

            ApplicationUser user = db.Users
                .Where(r => r.Email == oudePatient.Email)
                .FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (oudePatient.Email != nieuwePatient.Email)
                {
                    if (db.Users.Where(r => r.Email == nieuwePatient.Email).Count() == 0)
                    {
                        oudePatient.Vnaam = nieuwePatient.Vnaam;
                        oudePatient.Anaam = nieuwePatient.Anaam;
                        oudePatient.Email = nieuwePatient.Email;
                        user.Email = nieuwePatient.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuwePatient);
                }
                else
                {
                    if (db.Users.Where(r => r.Email == nieuwePatient.Email).Count() == 1)
                    {
                        oudePatient.Vnaam = nieuwePatient.Vnaam;
                        oudePatient.Anaam = nieuwePatient.Anaam;
                        oudePatient.Email = nieuwePatient.Email;
                        user.Email = nieuwePatient.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuwePatient);
                }
            }

            return View(nieuwePatient);
        }

        // GET: PatientMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PatientMantelzorgers.Find(id));
        }

        // POST: PatientMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            PatientMantelzorger patient = db.PatientMantelzorgers.Find(id);
            ApplicationUser user = db.Users.Where(r => r.Email == patient.Email).FirstOrDefault();

            try
            {
                db.PatientMantelzorgers.Remove(patient);
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Er is al een vragenlijst verstuurd geweest naar deze patiënt, waardoor deze niet verwijderd kan worden.");
                return View(patient);
            }
        }
    }
}
