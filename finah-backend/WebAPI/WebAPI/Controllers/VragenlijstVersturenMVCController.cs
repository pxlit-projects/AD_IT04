using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

            Vragenlijst vragenlijst = new Vragenlijst();
            vragenlijst.Dokter_Id = dokterId;

            return View(vragenlijst);
        }

        // GET: /VragenlijstVersturenMVC/VragenlijstVerstuurd
        [ValidateInput(false)]
        [Route("VragenlijstVersturenMVC/VragenlijstVerstuurd/{text}")]
        public ActionResult VragenlijstVerstuurd(string patientNaam, string mantelzorgerNaam, string vragenlijstBeschrijving)
        {
            ViewBag.PatientNaam = patientNaam;
            ViewBag.MantelzorgerNaam = mantelzorgerNaam;
            ViewBag.VragenlijstBeschrijving = vragenlijstBeschrijving;

            return View();
        }

        [HttpPost]
        public ActionResult _SendMessage(int patientId, int mantelzorgerId, int rapportId, int vragenlijstId)
        {
            PatientMantelzorger patient = db.PatientMantelzorgers.Find(patientId);
            PatientMantelzorger mantelzorger = db.PatientMantelzorgers.Find(mantelzorgerId);

            // Create the email object first, then add the properties.
            SendGridMessage messageToPatient = new SendGridMessage();
            messageToPatient.AddTo(patient.Email);
            messageToPatient.From = new MailAddress("mail@finah.com", "Finah");
            messageToPatient.Subject = "Finah vragenlijst";
            messageToPatient.Text = "Beste " + patient.Vnaam + " " + patient.Anaam + ", \n\n"
                + "via volgende link kom je uit op je finah-vragenlijst: \n\n"
                + "http://webclientfinah.azurewebsites.net/?verzorger=false&rapportId=" + rapportId + "&vragenlijstId=" + vragenlijstId +
                "\n\n Mvg, \n\n Finah";

            // Create the email object first, then add the properties.
            SendGridMessage messageToMantelzorger = new SendGridMessage();
            messageToMantelzorger.AddTo(mantelzorger.Email);
            messageToMantelzorger.From = new MailAddress("mail@finah.com", "Finah");
            messageToMantelzorger.Subject = "Finah vragenlijst";
            messageToMantelzorger.Text = "Beste " + mantelzorger.Vnaam + " " + mantelzorger.Anaam + ", \n\n"
                + "via volgende link kom je uit op je finah-vragenlijst voor je patiënt " + patient.Vnaam + " " + patient.Anaam + ": \n\n"
                + "http://webclientfinah.azurewebsites.net/?verzorger=true&rapportId=" + rapportId + "&vragenlijstId=" + vragenlijstId +
                "\n\n Mvg, \n\n Finah";

            // Create credentials, specifying your user name and password.
            var credentials = new NetworkCredential("azure_73831b50370c5a0dbf1553c548f93e44@azure.com", "2zylOlXk4oYhh1l");

            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            // Send the emails.
            transportWeb.DeliverAsync(messageToPatient);
            transportWeb.DeliverAsync(messageToMantelzorger);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}