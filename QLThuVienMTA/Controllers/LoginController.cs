﻿using QLThuVienMTA.Common;
using QLThuVienMTA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLThuVienMTA.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.password);
                if(result)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION ,userSession);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(" ", "đăng nhập không đúng!");
                }
            }
            return View("Index");
        }
    }
}