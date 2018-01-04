﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleconApp.Models;

namespace TeleconApp.Controllers
{
    public class ApplicationBaseController : Controller
    {
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (User != null)
            {
                var context = new ApplicationDbContext();
                var username = User.Identity.Name;

                if (!string.IsNullOrEmpty(username))
                {
                    var user = context.Users.SingleOrDefault(u => u.UserName == username);
                    string fullName =  user.TechName;
                    ViewData.Add("FullName", user.TechName);
                    ViewData.Add("UserName", user.UserName);
                }
            }
            base.OnActionExecuted(filterContext);
        }
        public ApplicationBaseController()
        { }
    }
}