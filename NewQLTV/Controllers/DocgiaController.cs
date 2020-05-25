using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewQLTV.Models;

namespace QLThuVienMTA.Controllers
{
    public class DocgiaController : Controller
    {
        // GET: Docgia
        public ActionResult Index()
        {
            using (ModelDbContext Dbmodel = new ModelDbContext())
            {
                return View(Dbmodel.DOCGIAs.ToList());
            }
        }

        // GET: Docgia/Details/5
        public ActionResult Details(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DOCGIAs.Where(x => x.MASINHVIEN == id).FirstOrDefault());
            }
        }

        // GET: Docgia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docgia/Create
        [HttpPost]
        public ActionResult Create(DOCGIA dOCGIA,  HttpPostedFileBase uploadImage)
        {
            try
            {
                string fileName = Path.GetFileNameWithoutExtension(uploadImage.FileName);
                string extension = Path.GetExtension(uploadImage.FileName);
                string filePath = Path.Combine(Server.MapPath("~/Images"), fileName);
                filePath = filePath + extension;
                uploadImage.SaveAs(filePath);
                dOCGIA.image = fileName + extension;

                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.DOCGIAs.Add(dOCGIA);
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

        // GET: Docgia/Edit/5
        public ActionResult Edit(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DOCGIAs.Where(x => x.MASINHVIEN == id).FirstOrDefault());
            }
        }

        // POST: Docgia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DOCGIA dOCGIA,  HttpPostedFileBase uploadImage)
        {
            try
            {
                if (Request.Form["image"] != null)
                {
                    if (dOCGIA.image != null)
                    {
                        string filePathOld = Path.Combine(Server.MapPath("~/Images"), dOCGIA.image);
                        System.IO.File.Delete(filePathOld);
                    }

                    string fileName = Path.GetFileNameWithoutExtension(uploadImage.FileName);
                    string extension = Path.GetExtension(uploadImage.FileName);
                    string filePathNew = Path.Combine(Server.MapPath("~/Images"), fileName);
                    filePathNew = filePathNew + extension;
                    uploadImage.SaveAs(filePathNew);
                    dOCGIA.image = fileName + extension;
                }
                using (ModelDbContext modelDbContext = new ModelDbContext())
                {
                    modelDbContext.Entry(dOCGIA).State = EntityState.Modified;
                    modelDbContext.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Docgia/Delete/5
        public ActionResult Delete(int id)
        {
            using (ModelDbContext modelDbContext = new ModelDbContext())
            {

                return View(modelDbContext.DOCGIAs.Where(x => x.MASINHVIEN == id).FirstOrDefault());
            }
        }

        // POST: Docgia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            try
            {
                using (ModelDbContext modeldbContext = new ModelDbContext())
                {
                    DOCGIA dOCGIA = modeldbContext.DOCGIAs.Where(x => x.MASINHVIEN == id).FirstOrDefault();

                    if (dOCGIA.image != null)
                    {
                        string filePath = Path.Combine(Server.MapPath("~/Images"), dOCGIA.image);
                        System.IO.File.Delete(filePath);
                    }


                    modeldbContext.DOCGIAs.Remove(dOCGIA);
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
