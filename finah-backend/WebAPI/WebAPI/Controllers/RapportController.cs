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
    public class RapportController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Rapport
        public IQueryable<Rapport> GetRapporten()
        {
            return db.Rapporten;
        }

        // GET: api/Rapport/5
        [ResponseType(typeof(Rapport))]
        public IHttpActionResult GetRapportenByDokterId(int id)
        {
            var model = db.Rapporten.Where(r => r.Dokter_Id == id);
            if (model.Count() == 0)
            {
                return NotFound();
            }
            return Ok(model);
        }

        // PUT: api/Rapport/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRapport(int id, Rapport rapport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rapport.Id)
            {
                return BadRequest();
            }

            db.Entry(rapport).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RapportExists(id))
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

        // POST: api/Rapport
        [ResponseType(typeof(Rapport))]
        public IHttpActionResult PostRapport(Rapport rapport)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rapporten.Add(rapport);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rapport.Id }, rapport);
        }

        // DELETE: api/Rapport/5
        [ResponseType(typeof(Rapport))]
        public IHttpActionResult DeleteRapport(int id)
        {
            Rapport rapport = db.Rapporten.Find(id);
            if (rapport == null)
            {
                return NotFound();
            }

            db.Rapporten.Remove(rapport);
            db.SaveChanges();

            return Ok(rapport);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RapportExists(int id)
        {
            return db.Rapporten.Count(e => e.Id == id) > 0;
        }
    }
}