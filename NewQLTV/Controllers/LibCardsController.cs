using NewQLTV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewQLTV.Controllers
{
    public class LibCardsController : Controller
    {
        // GET: LibCards
        public ActionResult Index()
        {
            using(ModelDbContext db = new ModelDbContext())
            return View(db.THETHUVIENs.ToList());
        }

        // GET: LibCards/Details/5
        public ActionResult Details(int id)
        {
            using (ModelDbContext db = new ModelDbContext())
            {
                return View(db.THETHUVIENs.Where(x =>x.MATHETV == id).FirstOrDefault());
            }
        }

        // GET: LibCards/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LibCards/Create
        [HttpPost]
        public ActionResult Create(THETHUVIEN tHETHUVIEN)
        {
            try
            {
                using(ModelDbContext db = new ModelDbContext())
                {
                    db.THETHUVIENs.Add(tHETHUVIEN);
                    db.SaveChanges();
                }    
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LibCards/Edit/5
        public ActionResult Edit(int id)
        {
            using(ModelDbContext db = new ModelDbContext())
                
            return View(db.THETHUVIENs.Where(x=>x.MATHETV == id ).FirstOrDefault());
        }

        // POST: LibCards/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, THETHUVIEN tHETHUVIEN)
        {
            try
            {
                using (ModelDbContext db = new ModelDbContext())
                {
                    db.Entry(tHETHUVIEN).State = EntityState.Modified;
                    db.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LibCards/Delete/5
        public ActionResult Delete(int id)
        {
            using(ModelDbContext db = new ModelDbContext())
            return View(db.THETHUVIENs.Where(x=>x.MATHETV ==id ).FirstOrDefault());
        }

        // POST: LibCards/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using(ModelDbContext db = new ModelDbContext())
                {
                    THETHUVIEN tHETHUVIEN = db.THETHUVIENs.Where(x => x.MATHETV == id).FirstOrDefault();
                    db.THETHUVIENs.Remove(tHETHUVIEN);
                    db.SaveChanges();
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
