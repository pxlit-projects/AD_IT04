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
    public class VragenlijstController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Vragenlijst
        public IQueryable<Vragenlijst> GetVragenlijsten()
        {
            return db.Vragenlijsten;
        }

        // GET: api/Vragenlijst/5
        [ResponseType(typeof(Vragenlijst))]
        public IHttpActionResult GetVragenlijst(int id)
        {
            var model = db.Vragenlijsten.Where(r => r.Dokter_Id == id);
            if (model.Count() == 0)
            {
                return NotFound();
            }
            return Ok(model);
        }

        // PUT: api/Vragenlijst/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVragenlijst(int id, Vragenlijst vragenlijst)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vragenlijst.Id)
            {
                return BadRequest();
            }

            db.Entry(vragenlijst).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VragenlijstExists(id))
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

        // POST: api/Vragenlijst
        [ResponseType(typeof(Vragenlijst))]
        public IHttpActionResult PostVragenlijst(Vragenlijst vragenlijst)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vragenlijsten.Add(vragenlijst);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vragenlijst.Id }, vragenlijst);
        }

        // DELETE: api/Vragenlijst/5
        [ResponseType(typeof(Vragenlijst))]
        public IHttpActionResult DeleteVragenlijst(int id)
        {
            Vragenlijst vragenlijst = db.Vragenlijsten.Find(id);
            if (vragenlijst == null)
            {
                return NotFound();
            }

            db.Vragenlijsten.Remove(vragenlijst);
            db.SaveChanges();

            return Ok(vragenlijst);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VragenlijstExists(int id)
        {
            return db.Vragenlijsten.Count(e => e.Id == id) > 0;
        }
    }
}