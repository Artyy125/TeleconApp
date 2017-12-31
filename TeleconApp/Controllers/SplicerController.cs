using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleconApp.Models;

namespace TeleconApp.Controllers
{
    public class SplicerController : Controller
    {
        // GET: Splicer
        public ActionResult Index()
        {
            SplicerModel sm = new SplicerModel();
            
            return View();
        }
        public ActionResult Test()
        {
            SplicerModel sm = new SplicerModel();

            return View();
        }
        public ActionResult TimeSheet()
        {
            SplicerModel sm = new SplicerModel();

            return View();
        }
    }
}