using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DokterMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public DokterMVCController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        //
        // GET: /DokterMVC/
        public ActionResult Index()
        {
            var model = db.Dokters;

            return View(model);
        }

        //
        // GET: /DokterMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DokterMVC/Create
        [HttpPost]
        public ActionResult Create(WebAPI.Models.Dokter dokter)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Where(r => r.Email == dokter.Email).FirstOrDefault() == null)
                {
                    db.Dokters.Add(dokter);
                    db.SaveChanges();

                    var user = new ApplicationUser { UserName = dokter.Email, Email = dokter.Email };
                    manager.Create(user, "P@ssw0rd");
                    manager.AddToRole(user.Id, "Dokter");

                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                return View(dokter);
            }

            return View(dokter);
        }

        //
        // GET: /DokterMVC/Edit/5
        public ActionResult Edit(int id)
        {
            WebAPI.Models.Dokter dokter = db.Dokters.Find(id);

            if (dokter == null)
            {
                return HttpNotFound();
            }

            return View(dokter);
        }

        //oudeDokter
        // POST: /DokterMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(Dokter nieuweDokter)
        {
            Dokter oudeDokter = db.Dokters.Find(nieuweDokter.Id);

            ApplicationUser user = db.Users
                .Where(r => r.Email == oudeDokter.Email)
                .FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (oudeDokter.Email != nieuweDokter.Email)
                {
                    if (db.Users.Where(r => r.Email == nieuweDokter.Email) == null)
                    {
                        oudeDokter.Vnaam = nieuweDokter.Vnaam;
                        oudeDokter.Anaam = nieuweDokter.Anaam;
                        oudeDokter.Email = nieuweDokter.Email;
                        user.Email = nieuweDokter.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweDokter);
                }
                else
                {
                    if (db.Users.Where(r => r.Email == nieuweDokter.Email).Count() == 1)
                    {
                        oudeDokter.Vnaam = nieuweDokter.Vnaam;
                        oudeDokter.Anaam = nieuweDokter.Anaam;
                        oudeDokter.Email = nieuweDokter.Email;
                        user.Email = nieuweDokter.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweDokter);
                }
            }

            return View(nieuweDokter);
        }

        //
        // GET: /DokterMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Dokters.Find(id));
        }

        //
        // POST: /DokterMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Dokter dokter = db.Dokters.Find(id);
            ApplicationUser user = db.Users.Where(r => r.Email == dokter.Email).FirstOrDefault();

            try
            {
                db.Dokters.Remove(dokter);
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Deze dokter heeft al patiënten, mantelzorgers of vragenlijsten toegevoegd en kan daarom niet verwijderd worden");
                return View(dokter);
            }
        }
    }
}
