using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class RapportMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public RapportMVCController()
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

            var model = db.Rapporten
                .Where(r => r.Dokter_Id == dokterId)
                .Select(r => new RapportListViewModel
                {
                    Id = r.Id,
                    PatientVnaam = (db.PatientMantelzorgers.Where(re => re.Id == r.Patient_Id).Select(rev => rev.Vnaam).FirstOrDefault()),
                    PatientAnaam = (db.PatientMantelzorgers.Where(re => re.Id == r.Patient_Id).Select(rev => rev.Anaam).FirstOrDefault()),
                    MantelzorgerVnaam = (db.PatientMantelzorgers.Where(re => re.Id == r.Mantelzorger_Id).Select(rev => rev.Vnaam).FirstOrDefault()),
                    MantelzorgerAnaam = (db.PatientMantelzorgers.Where(re => re.Id == r.Mantelzorger_Id).Select(rev => rev.Anaam).FirstOrDefault()),
                    VragenlijstBeschrijving = (db.Vragenlijsten.Where(re => re.Id == r.Vragenlijst_Id).Select(rev => rev.Beschrijving).FirstOrDefault()),
                    Date = r.Date
                });

            return View(model);
        }

        // GET: RapportMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RapportMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RapportMVC/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RapportMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RapportMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RapportMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RapportMVC/Delete/5
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
