﻿using Microsoft.AspNet.Identity;
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
    public class MantelzorgerMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public MantelzorgerMVCController()
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
                .Where(r => r.Dokter_Id == dokterId && r.Verzorger == true);

            return View(model);
        }

        // GET: MantelzorgerMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MantelzorgerMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MantelzorgerMVC/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(WebAPI.Models.PatientMantelzorger mantelzorger)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Where(r => r.Email == mantelzorger.Email).FirstOrDefault() == null)
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

                    mantelzorger.Verzorger = true;
                    mantelzorger.Dokter_Id = dokterId;

                    db.PatientMantelzorgers.Add(mantelzorger);
                    db.SaveChanges();

                    var user = new ApplicationUser { UserName = mantelzorger.Email, Email = mantelzorger.Email };
                    manager.Create(user, "P@ssw0rd");
                    manager.AddToRole(user.Id, "PatientMantelzorger");

                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                return View(mantelzorger);
            }

            return View(mantelzorger);
        }

        // GET: MantelzorgerMVC/Edit
        public ActionResult Edit(int id)
        {
            WebAPI.Models.PatientMantelzorger mantelzorger = db.PatientMantelzorgers.Find(id);

            if (mantelzorger == null)
            {
                return HttpNotFound();
            }

            return View(mantelzorger);
        }

        // POST: MantelzorgerMVC/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PatientMantelzorger nieuweMantelzorger)
        {
            PatientMantelzorger oudeMantelzorger = db.PatientMantelzorgers.Find(nieuweMantelzorger.Id);

            ApplicationUser user = db.Users
                .Where(r => r.Email == oudeMantelzorger.Email)
                .FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (oudeMantelzorger.Email != nieuweMantelzorger.Email)
                {
                    if (db.Users.Where(r => r.Email == nieuweMantelzorger.Email).Count() == 0)
                    {
                        oudeMantelzorger.Vnaam = nieuweMantelzorger.Vnaam;
                        oudeMantelzorger.Anaam = nieuweMantelzorger.Anaam;
                        oudeMantelzorger.Email = nieuweMantelzorger.Email;
                        user.Email = nieuweMantelzorger.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweMantelzorger);
                }
                else
                {
                    if (db.Users.Where(r => r.Email == nieuweMantelzorger.Email).Count() == 1)
                    {
                        oudeMantelzorger.Vnaam = nieuweMantelzorger.Vnaam;
                        oudeMantelzorger.Anaam = nieuweMantelzorger.Anaam;
                        oudeMantelzorger.Email = nieuweMantelzorger.Email;
                        user.Email = nieuweMantelzorger.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweMantelzorger);
                }
            }

            return View(nieuweMantelzorger);
        }

        // GET: MantelzorgerMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.PatientMantelzorgers.Find(id));
        }

        // POST: MantelzorgerMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            PatientMantelzorger mantelzorger = db.PatientMantelzorgers.Find(id);
            ApplicationUser user = db.Users.Where(r => r.Email == mantelzorger.Email).FirstOrDefault();

            try
            {
                db.PatientMantelzorgers.Remove(mantelzorger);
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                ModelState.AddModelError("", "Er is al een vragenlijst verstuurd geweest naar deze mantelzorger, waardoor deze niet verwijderd kan worden.");
                return View(mantelzorger);
            }
        }
    }
}
