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
    public class VraagController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Vraag
        public IQueryable<Vraag> GetVragen()
        {
            return db.Vragen;
        }

        // GET: api/Vraag/5
        [ResponseType(typeof(Vraag))]
        public IHttpActionResult GetVraag(int id)
        {
            var model = db.Vragen.Where(r => r.Vragenlijst_Id == id);
            if (model.Count() == 0)
            {
                return NotFound();
            }
            return Ok(model);
        }

        // PUT: api/Vraag/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVraag(int id, Vraag vraag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vraag.Id)
            {
                return BadRequest();
            }

            db.Entry(vraag).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VraagExists(id))
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

        // POST: api/Vraag
        [ResponseType(typeof(Vraag))]
        public IHttpActionResult PostVraag(Vraag vraag)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Vragen.Add(vraag);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = vraag.Id }, vraag);
        }

        // DELETE: api/Vraag/5
        [ResponseType(typeof(Vraag))]
        public IHttpActionResult DeleteVraag(int id)
        {
            Vraag vraag = db.Vragen.Find(id);
            if (vraag == null)
            {
                return NotFound();
            }

            db.Vragen.Remove(vraag);
            db.SaveChanges();

            return Ok(vraag);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VraagExists(int id)
        {
            return db.Vragen.Count(e => e.Id == id) > 0;
        }
    }
}