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
    public class DokterController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Dokter
        public IQueryable<Dokter> GetDokters()
        {
            return db.Dokters;
        }

        // GET: api/Dokter/5
        [ResponseType(typeof(Dokter))]
        public IHttpActionResult GetDokter(int id)
        {
            Dokter dokter = db.Dokters.Find(id);
            if (dokter == null)
            {
                return NotFound();
            }

            return Ok(dokter);
        }

        // PUT: api/Dokter/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDokter(int id, Dokter dokter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dokter.Id)
            {
                return BadRequest();
            }

            db.Entry(dokter).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DokterExists(id))
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

        // POST: api/Dokter
        [ResponseType(typeof(Dokter))]
        public IHttpActionResult PostDokter(Dokter dokter)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Dokters.Add(dokter);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = dokter.Id }, dokter);
        }

        // DELETE: api/Dokter/5
        [ResponseType(typeof(Dokter))]
        public IHttpActionResult DeleteDokter(int id)
        {
            Dokter dokter = db.Dokters.Find(id);
            if (dokter == null)
            {
                return NotFound();
            }

            db.Dokters.Remove(dokter);
            db.SaveChanges();

            return Ok(dokter);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DokterExists(int id)
        {
            return db.Dokters.Count(e => e.Id == id) > 0;
        }
    }
}