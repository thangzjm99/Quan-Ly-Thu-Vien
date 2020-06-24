using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewQLTV.Models;

namespace QLThuVienMTA.Controllers
{
    public class TrasachController : Controller
    {
        // GET: Trasach
        public ActionResult Index()
        {
            using (ModelDbContext Dbmodel = new ModelDbContext())
            {
                return View(Dbmodel.TRASACHes.ToList());
            }
        }

        // GET: Trasach/Details/5
        public ActionResult Details(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.TRASACHes.Where(x => x.MATRASACH == id).FirstOrDefault());
            }
        }

        // GET: Trasach/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trasach/Create
        [HttpPost]
        public ActionResult Create(TRASACH tRASACH)
        {
            try
            {
                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.TRASACHes.Add(tRASACH);
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

        // GET: Trasach/Edit/5
        public ActionResult Edit(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.TRASACHes.Where(x => x.MATRASACH == id).FirstOrDefault());
            }
        }

        // POST: Trasach/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TRASACH tRASACH)
        {
            try
            {

                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.Entry(tRASACH).State = EntityState.Modified;
                    modelDbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trasach/Delete/5
        public ActionResult Delete(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.TRASACHes.Where(x => x.MATRASACH == id).FirstOrDefault());
            }
        }

        // POST: Trasach/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (ModelDbContext modeldbContext = new ModelDbContext())
                {
                    TRASACH tRASACH = modeldbContext.TRASACHes.Where(x => x.MATRASACH == id).FirstOrDefault();
                    modeldbContext.TRASACHes.Remove(tRASACH);
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
