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
    [Authorize(Roles = "Dokter, Onderzoeker")]
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
            if (User.IsInRole("Onderzoeker"))
            {
                var model = db.Rapporten
                    .Select(r => new RapportListViewModel
                    {
                        Id = r.Id,
                        VragenlijstBeschrijving = (db.Vragenlijsten.Where(re => re.Id == r.Vragenlijst_Id).Select(rev => rev.Beschrijving).FirstOrDefault()),
                        Date = r.Date,
                        HasAnswers = (db.Antwoorden.Where(re => re.Rapport_Id == r.Id).Count() == (db.Vragen.Where(t => t.Vragenlijst_Id == r.Vragenlijst_Id).Count() * 2))
                    });

                return View(model);
            }
            else
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
                        Date = r.Date,
                        HasAnswers = (db.Antwoorden.Where(re => re.Rapport_Id == r.Id).Count() == (db.Vragen.Where(t => t.Vragenlijst_Id == r.Vragenlijst_Id).Count() * 2))
                    });

                return View(model);
            }
        }

        // GET: RapportMVC/Show/5
        public ActionResult Show(int id)
        {
            var rapport = db.Rapporten.Find(id);
            var patient = db.PatientMantelzorgers.Find(rapport.Patient_Id);
            var mantelzorger = db.PatientMantelzorgers.Find(rapport.Mantelzorger_Id);

            WebAPI.Models.RapportDetailsModel rapportDetailsModel = new RapportDetailsModel();
            rapportDetailsModel.Id = id;

            if (User.IsInRole("Dokter"))
            {
                rapportDetailsModel.PatientVnaam = patient.Vnaam;
                rapportDetailsModel.PatientAnaam = patient.Anaam;
                rapportDetailsModel.MantelzorgerVnaam = mantelzorger.Vnaam;
                rapportDetailsModel.MantelzorgerAnaam = mantelzorger.Anaam;
            }

            rapportDetailsModel.Date = rapport.Date;

            var vragen = db.Vragen.Where(r => r.Vragenlijst_Id == rapport.Vragenlijst_Id);
            var i = 0;

            rapportDetailsModel.Vragen = new Vraag[vragen.Count()];

            foreach (Vraag vraag in vragen)
            {
                rapportDetailsModel.Vragen[i] = vraag;
                i++;
            }

            var antwoorden = db.Antwoorden.Where(r => r.Rapport_Id == id).OrderBy(re => re.Verzorger);
            var j = 0;

            rapportDetailsModel.Antwoorden = new Antwoord[antwoorden.Count()];

            foreach (Antwoord antwoord in antwoorden)
            {
                rapportDetailsModel.Antwoorden[j] = antwoord;
                j++;
            }

            return View(rapportDetailsModel);
        }

        // GET: RapportMVC/Herhaal/5
        [HttpGet]
        public ActionResult Herhaal(int id)
        {
            Rapport rapport = db.Rapporten.Find(id);

            RapportListViewModel model = new RapportListViewModel();
            model.PatientVnaam = (db.PatientMantelzorgers.Where(r => r.Id == rapport.Patient_Id).Select(rev => rev.Vnaam).FirstOrDefault());
            model.PatientAnaam = (db.PatientMantelzorgers.Where(r => r.Id == rapport.Patient_Id).Select(rev => rev.Anaam).FirstOrDefault());
            model.MantelzorgerVnaam = (db.PatientMantelzorgers.Where(r => r.Id == rapport.Mantelzorger_Id).Select(rev => rev.Vnaam).FirstOrDefault());
            model.MantelzorgerAnaam = (db.PatientMantelzorgers.Where(r => r.Id == rapport.Mantelzorger_Id).Select(rev => rev.Anaam).FirstOrDefault());
            model.VragenlijstBeschrijving = (db.Vragenlijsten.Where(r => r.Id == rapport.Vragenlijst_Id).Select(rev => rev.Beschrijving).FirstOrDefault());

            return View(model);
        }

        // POST: RapportMVC/Herhaal/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Herhaal(int id, FormCollection formvalues)
        {
            Rapport rapport = db.Rapporten.Find(id);

            Rapport newRapport = new Rapport();
            newRapport.Patient_Id = rapport.Patient_Id;
            newRapport.Mantelzorger_Id = rapport.Mantelzorger_Id;
            newRapport.Vragenlijst_Id = rapport.Vragenlijst_Id;
            newRapport.Dokter_Id = rapport.Dokter_Id;
            newRapport.Date = DateTime.Now;

            db.Rapporten.Add(newRapport);
            db.SaveChanges();

            var patient = db.PatientMantelzorgers.Find(newRapport.Patient_Id);
            var patientNaam = patient.Vnaam + " " + patient.Anaam;

            var mantelzorger = db.PatientMantelzorgers.Find(newRapport.Mantelzorger_Id);
            var mantelzorgerNaam = mantelzorger.Vnaam + " " + mantelzorger.Anaam;

            var vragenlijst = db.Vragenlijsten.Find(newRapport.Vragenlijst_Id);

            var result = new VragenlijstVersturenMVCController()
                ._SendMessage(newRapport.Patient_Id, newRapport.Mantelzorger_Id, newRapport.Id, newRapport.Vragenlijst_Id);

            return RedirectToAction("VragenlijstVerstuurd", "VragenlijstVersturenMVC", new
            {
                patientNaam = patientNaam,
                mantelzorgerNaam = mantelzorgerNaam,
                vragenlijstBeschrijving = vragenlijst.Beschrijving
            });
        }
    }
}
