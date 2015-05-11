using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OnderzoekerMVCController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> manager;

        public OnderzoekerMVCController()
        {
            db = new ApplicationDbContext();
            manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
        }

        //
        // GET: /OnderzoekerMVC/
        public ActionResult Index()
        {
            var model = db.Onderzoekers;

            return View(model);
        }

        //
        // GET: /OnderzoekerMVC/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OnderzoekerMVC/Create
        [HttpPost]
        public ActionResult Create(WebAPI.Models.Onderzoeker onderzoeker)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Where(r => r.Email == onderzoeker.Email).FirstOrDefault() == null)
                {
                    db.Onderzoekers.Add(onderzoeker);
                    db.SaveChanges();

                    var user = new ApplicationUser { UserName = onderzoeker.Email, Email = onderzoeker.Email };
                    manager.Create(user, "P@ssw0rd");
                    manager.AddToRole(user.Id, "Onderzoeker");

                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                return View(onderzoeker);
            }

            return View(onderzoeker);
        }

        //
        // GET: /OnderzoekerMVC/Edit/5
        public ActionResult Edit(int id)
        {
            WebAPI.Models.Onderzoeker onderzoeker = db.Onderzoekers.Find(id);

            if (onderzoeker == null)
            {
                return HttpNotFound();
            }

            return View(onderzoeker);
        }

        //
        // POST: /OnderzoekerMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(Onderzoeker nieuweOnderzoeker)
        {
            Onderzoeker oudeOnderzoeker = db.Onderzoekers.Find(nieuweOnderzoeker.Id);

            ApplicationUser user = db.Users
                .Where(r => r.Email == oudeOnderzoeker.Email)
                .FirstOrDefault();

            if (ModelState.IsValid)
            {
                if (oudeOnderzoeker.Email != nieuweOnderzoeker.Email)
                {
                    if (db.Users.Where(r => r.Email == nieuweOnderzoeker.Email) == null)
                    {
                        oudeOnderzoeker.Vnaam = nieuweOnderzoeker.Vnaam;
                        oudeOnderzoeker.Anaam = nieuweOnderzoeker.Anaam;
                        oudeOnderzoeker.Email = nieuweOnderzoeker.Email;
                        user.Email = nieuweOnderzoeker.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweOnderzoeker);
                }
                else
                {
                    if (db.Users.Where(r => r.Email == nieuweOnderzoeker.Email).Count() == 1)
                    {
                        oudeOnderzoeker.Vnaam = nieuweOnderzoeker.Vnaam;
                        oudeOnderzoeker.Anaam = nieuweOnderzoeker.Anaam;
                        oudeOnderzoeker.Email = nieuweOnderzoeker.Email;
                        user.Email = nieuweOnderzoeker.Email;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index");
                    }

                    ModelState.AddModelError("", "Dit email-adres is al gekoppeld aan een account, gelieve een ander te kiezen");
                    return View(nieuweOnderzoeker);
                }
            }

            return View(nieuweOnderzoeker);
        }

        //
        // GET: /OnderzoekerMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Onderzoekers.Find(id));
        }

        //
        // POST: /OnderzoekerMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Onderzoeker onderzoeker = db.Onderzoekers.Find(id);
            ApplicationUser user = db.Users.Where(r => r.Email == onderzoeker.Email).FirstOrDefault();

            try
            {
                db.Onderzoekers.Remove(onderzoeker);
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(onderzoeker);
            }
        }
    }
}
