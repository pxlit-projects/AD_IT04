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
    //[Authorize(Roles = "Dokter")]
    public class VragenlijstVersturenMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public VragenlijstVersturenMVCController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        //
        // GET: /VragenlijstVersturenMVC/
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

            WebAPI.Models.VragenlijstVersturenModel vragenlijstVersturenModel = new Models.VragenlijstVersturenModel();

            var hulp = db.PatientMantelzorgers.Where(r => r.Dokter_Id == dokterId && r.Verzorger == false);

            vragenlijstVersturenModel.Patienten = new PatientMantelzorger[hulp.Count()];

            var i = 0;

            foreach (PatientMantelzorger patient in hulp)
            {
                vragenlijstVersturenModel.Patienten[i] = patient;
                i++;
            }

            var hulp2 = db.PatientMantelzorgers.Where(r => r.Dokter_Id == dokterId && r.Verzorger == true);

            vragenlijstVersturenModel.Mantelzorgers = new PatientMantelzorger[hulp2.Count()];

            var j = 0;

            foreach (PatientMantelzorger mantelzorger in hulp2)
            {
                vragenlijstVersturenModel.Mantelzorgers[j] = mantelzorger;
                j++;
            }

            var hulp3 = db.Vragenlijsten.Where(r => r.Dokter_Id == dokterId);

            vragenlijstVersturenModel.Vragenlijsten = new Vragenlijst[hulp3.Count()];

            var k = 0;

            foreach (Vragenlijst vragenlijst in hulp3)
            {
                vragenlijstVersturenModel.Vragenlijsten[k] = vragenlijst;
                k++;
            }

            return View(vragenlijstVersturenModel);
        }

        // POST: VragenlijstVersturenMVC/
        [HttpPost]
        public ActionResult Index(VragenlijstVersturenModel vragenlijstVersturenModel)
        {

            //var currentUser = manager.FindById(User.Identity.GetUserId());

            //var dokterId = 0;
            //if (currentUser != null)
            //{
            //    dokterId = db.Dokters
            //   .Where(r => r.Email == currentUser.Email)
            //   .Select(r => r.Id)
            //   .FirstOrDefault();
            //}

            //Rapport rapport = new Rapport();
            //rapport.Dokter_Id = dokterId;
            //rapport.Patient_Id = vragenlijstVersturenModel.Values[0];
            //rapport.Mantelzorger_Id = vragenlijstVersturenModel.Values[1];
            //rapport.Vragenlijst_Id = vragenlijstVersturenModel.Values[2];

            //db.Rapporten.Add(rapport);
            //db.SaveChanges();

            return RedirectToAction("VragenlijstVerstuurd");

        }

        //
        // GET: /VragenlijstVersturen/VragenlijstVerstuurd
        public ActionResult VragenlijstVerstuurd()
        {
            return View();
        }


    }
}