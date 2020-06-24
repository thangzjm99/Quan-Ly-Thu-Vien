using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewQLTV.Models;

namespace QLThuVienMTA.Controllers
{
    public class MuonsachController : Controller
    {
        // GET: Muonsach
        public ActionResult Index()
        {
            using (ModelDbContext Dbmodel = new ModelDbContext())
            {
                return View(Dbmodel.MUONSACKs.ToList());
            }
        }

        // GET: Muonsach/Details/5
        public ActionResult Details(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.MUONSACKs.Where(x => x.MAMUONSACH == id).FirstOrDefault());
            }
        }


        // GET: Muonsach/Create
        public ActionResult Create()
        {
            
            return View();
             

        }

        // POST: Muonsach/Create
        [HttpPost]
        public ActionResult Create(MUONSACK mUONSACK)
        {
            try
            {
                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    
                    modelDbContext.MUONSACKs.Add(mUONSACK);
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

        // GET: Muonsach/Edit/5
        public ActionResult Edit(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.MUONSACKs.Where(x => x.MAMUONSACH == id).FirstOrDefault());
            }
        }

        // POST: Muonsach/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MUONSACK mUONSACK)
        {
            try
            {

                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.Entry(mUONSACK).State = EntityState.Modified;
                    modelDbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Muonsach/Delete/5
        public ActionResult Delete(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.MUONSACKs.Where(x => x.MAMUONSACH == id).FirstOrDefault());
            }
        }

        // POST: Muonsach/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (ModelDbContext modeldbContext = new ModelDbContext())
                {
                    MUONSACK mUONSACK = modeldbContext.MUONSACKs.Where(x => x.MAMUONSACH == id).FirstOrDefault();
                    modeldbContext.MUONSACKs.Remove(mUONSACK);
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
