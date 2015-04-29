using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OnderzoekerMVCController : Controller
    {
        //
        // GET: /OnderzoekerMVC/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /OnderzoekerMVC/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OnderzoekerMVC/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /OnderzoekerMVC/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /OnderzoekerMVC/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /OnderzoekerMVC/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
