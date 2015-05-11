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
            var users = db.Users.Where(r => r.Roles.Any(
                re => re.RoleId == (db.Roles.Where(rev => rev.Name == "Onderzoeker")
                    .Select(rev => rev.Id).FirstOrDefault())));

            return View(users);
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
                var user = new ApplicationUser { UserName = onderzoeker.Email, Email = onderzoeker.Email };
                manager.Create(user, "P@ssw0rd");
                manager.AddToRole(user.Id, "Onderzoeker");

                return RedirectToAction("Index");
            }

            return View(onderzoeker);
        }

        //
        // GET: /OnderzoekerMVC/Edit/5
        public ActionResult Edit(String email)
        {
            Onderzoeker onderzoeker = new Onderzoeker();
            onderzoeker.Email = email;

            return View(onderzoeker);
        }

        //
        // POST: /OnderzoekerMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(Onderzoeker nieuweOnderzoeker)
        {
            //Onderzoeker oudeOnderzoeker = db.Onderzoekers.Find(nieuweOnderzoeker.Id);

            //ApplicationUser user = db.Users
            //    .Where(r => r.Email == oudeOnderzoeker.Email)
            //    .FirstOrDefault();

            //if (ModelState.IsValid)
            //{
            //    oudeOnderzoeker.Vnaam = nieuweOnderzoeker.Vnaam;
            //    oudeOnderzoeker.Anaam = nieuweOnderzoeker.Anaam;
            //    oudeOnderzoeker.Email = nieuweOnderzoeker.Email;
            //    user.Email = nieuweOnderzoeker.Email;
            //    db.Entry(user).State = EntityState.Modified;
            //    db.SaveChanges();

            //    return RedirectToAction("Index");
            //}

            return View(nieuweOnderzoeker);
        }

        //
        // GET: /OnderzoekerMVC/Delete/5
        public ActionResult Delete(String email)
        {
            Onderzoeker onderzoeker = new Onderzoeker();
            onderzoeker.Email = email;

            return View(onderzoeker);
        }

        //
        // POST: /OnderzoekerMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(Onderzoeker onderzoeker)
        {
            ApplicationUser user = db.Users.Where(r => r.Email == onderzoeker.Email).FirstOrDefault();

            try
            {
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(user);
            }
        }
    }
}
