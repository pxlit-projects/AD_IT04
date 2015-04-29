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
    public class AntwoordController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Antwoord
        public IQueryable<Antwoord> GetAntwoorden()
        {
            return db.Antwoorden;
        }

        // GET: api/Antwoord/5
        [ResponseType(typeof(Antwoord))]
        public IHttpActionResult GetAntwoordenByRapportId(int id)
        {
            var model = db.Antwoorden.Where(r => r.Rapport_Id == id);
            if (model.Count() == 0)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Antwoord/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAntwoord(int id, Antwoord antwoord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != antwoord.Id)
            {
                return BadRequest();
            }

            db.Entry(antwoord).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AntwoordExists(id))
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

        // POST: api/Antwoord
        [ResponseType(typeof(Antwoord))]
        public IHttpActionResult PostAntwoord(Antwoord antwoord)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Antwoorden.Add(antwoord);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = antwoord.Id }, antwoord);
        }

        // DELETE: api/Antwoord/5
        [ResponseType(typeof(Antwoord))]
        public IHttpActionResult DeleteAntwoord(int id)
        {
            Antwoord antwoord = db.Antwoorden.Find(id);
            if (antwoord == null)
            {
                return NotFound();
            }

            db.Antwoorden.Remove(antwoord);
            db.SaveChanges();

            return Ok(antwoord);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AntwoordExists(int id)
        {
            return db.Antwoorden.Count(e => e.Id == id) > 0;
        }
    }
}