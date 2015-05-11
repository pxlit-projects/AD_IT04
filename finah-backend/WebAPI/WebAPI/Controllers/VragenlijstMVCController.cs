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
    public class VragenlijstMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public VragenlijstMVCController()
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

            var model = db.Vragenlijsten
                .Where(r => r.Dokter_Id == dokterId);

            return View(model);
        }

        // GET: VragenlijstMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VragenlijstMVC/Create
        public ActionResult Create()
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

            Vragenlijst vragenlijst = new Vragenlijst();
            vragenlijst.Dokter_Id = dokterId;

            return View(vragenlijst);
        }

        // GET: VragenlijstMVC/Edit/5
        public ActionResult Edit(int id)
        {
            WebAPI.Models.CustomVragenlijst customVragenlijst = new CustomVragenlijst();

            customVragenlijst.Id = id;
            customVragenlijst.Beschrijving = db.Vragenlijsten.Find(id).Beschrijving;

            var hulp = db.Vragen.Where(r => r.Vragenlijst_Id == id);

            customVragenlijst.Vragen = new Vraag[hulp.Count()];

            var i = 0;

            foreach (Vraag vraag in hulp)
            {
                customVragenlijst.Vragen[i] = vraag;
                i++;
            }

            return View(customVragenlijst);
        }

        // POST: VragenlijstMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(CustomVragenlijst customVragenlijst)
        {
            if (db.Rapporten.Where(r => r.Vragenlijst_Id == customVragenlijst.Id).FirstOrDefault() == null)
            {
                Vragenlijst vragenlijst = new Vragenlijst { Id = customVragenlijst.Id };
                db.Vragenlijsten.Attach(vragenlijst);

                vragenlijst.Beschrijving = customVragenlijst.Beschrijving;

                foreach (Vraag item in customVragenlijst.Vragen)
                {
                    Vraag vraag = db.Vragen.Find(item.Id);

                    if (item.Beschrijving != null)
                    {
                        vraag.Beschrijving = item.Beschrijving;
                    }
                    else
                    {
                        db.Vragen.Remove(vraag);
                    }
                }

                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(customVragenlijst);
        }

        // GET: VragenlijstMVC/Delete/5
        public ActionResult Delete(int id)
        {
            Vragenlijst vragenlijst = db.Vragenlijsten.Find(id);

            return View(vragenlijst);
        }

        // POST: VragenlijstMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Vragenlijst vragenlijst = db.Vragenlijsten.Find(id);

            if (db.Rapporten.Where(r => r.Vragenlijst_Id == id).FirstOrDefault() == null)
            {
                foreach (Vraag vraag in db.Vragen.Where(r => r.Vragenlijst_Id == id))
                {
                    db.Vragen.Remove(vraag);
                }

                db.SaveChanges();

                db.Vragenlijsten.Remove(vragenlijst);

                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Deze vragenlijst is al verstuurd geweest naar een patiënt en kan daarom niet verwijderd worden.");
                return View(vragenlijst);
            }
        }

        // GET: VragenlijstMVC/Show/5
        public ActionResult Show(int id)
        {
            WebAPI.Models.CustomVragenlijst customVragenlijst = new CustomVragenlijst();

            customVragenlijst.Id = id;
            customVragenlijst.Beschrijving = db.Vragenlijsten.Find(id).Beschrijving;

            var hulp = db.Vragen.Where(r => r.Vragenlijst_Id == id);

            customVragenlijst.Vragen = new Vraag[hulp.Count()];

            var i = 0;

            foreach (Vraag vraag in hulp)
            {
                customVragenlijst.Vragen[i] = vraag;
                i++;
            }

            return View(customVragenlijst);
        }
    }
}
