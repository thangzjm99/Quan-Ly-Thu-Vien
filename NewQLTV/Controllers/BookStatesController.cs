using NewQLTV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewQLTV.Controllers
{
    public class BookStatesController : Controller
    {
        public ModelDbContext db = new ModelDbContext();
        // GET: BookStates
        public ActionResult Index()
        {
            return View(db.TINHTRANGSACHes.ToList());
        }

        // GET: BookStates/Details/5
        public ActionResult Details(int id)
        {
            return View(db.TINHTRANGSACHes.Where(x=>x.MATINHTRANG == id).FirstOrDefault());
        }

        // GET: BookStates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookStates/Create
        [HttpPost]
        public ActionResult Create(TINHTRANGSACH tINHTRANGSACH)
        {
            try
            {
                db.TINHTRANGSACHes.Add(tINHTRANGSACH);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookStates/Edit/5
        public ActionResult Edit(int id)
        {

            return View(db.TINHTRANGSACHes.Where(x=>x.MATINHTRANG == id ).FirstOrDefault());
        }

        // POST: BookStates/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TINHTRANGSACH tINHTRANGSACH)
        {
            try
            {
                db.Entry(tINHTRANGSACH).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BookStates/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.TINHTRANGSACHes.Where(x=>x.MATINHTRANG == id ).FirstOrDefault());
        }

        // POST: BookStates/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                TINHTRANGSACH tINHTRANGSACH = db.TINHTRANGSACHes.Where(x => x.MATINHTRANG == id).FirstOrDefault();
                db.TINHTRANGSACHes.Remove(tINHTRANGSACH);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
