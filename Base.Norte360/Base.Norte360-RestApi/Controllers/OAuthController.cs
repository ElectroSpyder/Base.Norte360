using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Base.Norte360_RestApi.Controllers
{
    public class OAuthController : Controller
    {
        // GET: OAuth
        public ActionResult Index()
        {
            return View();
        }

        // GET: OAuth/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OAuth/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OAuth/Create
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

        // GET: OAuth/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OAuth/Edit/5
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

        // GET: OAuth/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OAuth/Delete/5
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
