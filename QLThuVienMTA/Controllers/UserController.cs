using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QLThuVienMTA;

namespace QLThuVienMTA.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                long id = dao.insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");

                }
                else
                {
                    ModelState.AddModelError("", "Đã thêm USER !");
                }
            }
            return View("Index");
        } 
    }
}