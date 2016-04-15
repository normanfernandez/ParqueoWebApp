using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ParqueoWebApp.Models;

namespace ParqueoWebApp.Controllers
{
    [Authorize]
    public class ParqueoController : Controller
    {
        // GET: Parqueo
        public ActionResult Index()
        {
            Models.PaqueoWebDataContext dc = new PaqueoWebDataContext();
            var q = from p in dc.Parqueos
                    select p;
            //ViewData["parqueos"] = new SelectList(q);
            return View(q);
        }

        // GET: Parqueo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Parqueo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parqueo/Create
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

        // GET: Parqueo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Parqueo/Edit/5
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

        // GET: Parqueo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Parqueo/Delete/5
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
