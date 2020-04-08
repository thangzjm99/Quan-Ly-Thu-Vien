using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewQLTV.Models;
using System.Data.Entity;

namespace NewQLTV.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            using ( ModelDbContext Dbmodel = new ModelDbContext())
            {
                return View(Dbmodel.DONGSACHes.ToList());
            }
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DONGSACHes.Where(x => x.MASACH == id).FirstOrDefault());
            }
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        public ActionResult Create(DONGSACH dONGSACH)
        {
            try
            {
                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.DONGSACHes.Add(dONGSACH);
                    modelDbContext.SaveChanges();
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DONGSACHes.Where(x => x.MASACH == id).FirstOrDefault());
            }
        }

        // POST: Books/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DONGSACH dONGSACH)
        {
            try
            {

                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.Entry(dONGSACH).State = EntityState.Modified;
                    modelDbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DONGSACHes.Where(x => x.MASACH == id).FirstOrDefault());
            }
        }

        // POST: Books/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (ModelDbContext modeldbContext = new ModelDbContext())
                {
                    DONGSACH dONGSACH = modeldbContext.DONGSACHes.Where(x => x.MASACH == id).FirstOrDefault();
                    modeldbContext.DONGSACHes.Remove(dONGSACH);
                    modeldbContext.SaveChanges();
                }
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
