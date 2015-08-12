﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
       public ActionResult Login()
       {
            return View();
       }

       [HttpPost]
       public ActionResult Login(AuthLogin form)
       {
            if (!ModelState.IsValid)
            {
                return View(form);
            }
            if(form.username!="test")
            {
                ModelState.AddModelError("username","Thats not valid");
                return View(form);
            }
            return Content("Is Valid!!!");
       } 
    }
}