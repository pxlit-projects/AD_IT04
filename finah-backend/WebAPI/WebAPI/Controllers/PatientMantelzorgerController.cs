using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PatientMantelzorgerController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private UserManager<ApplicationUser> manager;

        public PatientMantelzorgerController()
        {
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        // GET: api/PatientMantelzorger
        [Route("api/patientmantelzorger/{verzorger}")]
        public IHttpActionResult GetPatientMantelzorgers(Boolean verzorger)
        {
            var model = db.PatientMantelzorgers.Where(r => r.Verzorger == verzorger);

            return Ok(model);
        }

        // GET: api/PatientMantelzorger
        [Route("api/patientmantelzorger/{id}/{random}/{random2}/{random3}")]
        public IHttpActionResult GetPatientMantelzorger(int id, int random, int random2, int random3)
        {
            var model = db.PatientMantelzorgers.Where(r => r.Id == id);

            return Ok(model);
        }

        // GET: api/PatientMantelzorger
        [Route("api/patientmantelzorger/{dokter_Id}/{random}/{random2}")]
        public IHttpActionResult GetPatientMantelzorgersByDokterId(int dokter_Id, int random, int random2)
        {
            var model = db.PatientMantelzorgers.Where(r => r.Dokter_Id == dokter_Id);

            return Ok(model);
        }

        // GET: api/PatientMantelzorger/5/true
        [Route("api/patientmantelzorger/{id}/{verzorger}")]
        [ResponseType(typeof(PatientMantelzorger))]
        public IHttpActionResult GetPatientMantelzorgersByDokterId(int id, Boolean verzorger)
        {
            var model = db.PatientMantelzorgers.Where(r => r.Dokter_Id == id && r.Verzorger == verzorger);
            if (model.Count() == 0)
            {
                return NotFound();
            }
            return Ok(model);
        }

        // PUT: api/PatientMantelzorger/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPatientMantelzorger(int id, PatientMantelzorger patientMantelzorger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != patientMantelzorger.Id)
            {
                return BadRequest();
            }

            db.Entry(patientMantelzorger).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientMantelzorgerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/PatientMantelzorger
        [ResponseType(typeof(PatientMantelzorger))]
        public IHttpActionResult PostPatientMantelzorger(PatientMantelzorger patientMantelzorger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser { UserName = patientMantelzorger.Email, Email = patientMantelzorger.Email };
            manager.Create(user, "P@ssw0rd");
            manager.AddToRole(user.Id, "PatientMantelzorger");

            db.PatientMantelzorgers.Add(patientMantelzorger);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = patientMantelzorger.Id }, patientMantelzorger);
        }

        // DELETE: api/PatientMantelzorger/5
        [ResponseType(typeof(PatientMantelzorger))]
        public IHttpActionResult DeletePatientMantelzorger(int id)
        {
            PatientMantelzorger patientMantelzorger = db.PatientMantelzorgers.Find(id);
            if (patientMantelzorger == null)
            {
                return NotFound();
            }

            db.PatientMantelzorgers.Remove(patientMantelzorger);
            db.SaveChanges();

            return Ok(patientMantelzorger);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PatientMantelzorgerExists(int id)
        {
            return db.PatientMantelzorgers.Count(e => e.Id == id) > 0;
        }
    }
}