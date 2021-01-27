using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class FinacyController : Controller
    {
        // GET: Finacy
        public ActionResult Index()
        {
            return View();
        }

        // GET: Finacy/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Finacy/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Finacy/Create
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

        // GET: Finacy/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Finacy/Edit/5
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

        // GET: Finacy/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Finacy/Delete/5
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
