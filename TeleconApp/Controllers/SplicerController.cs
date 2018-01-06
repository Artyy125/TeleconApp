﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeleconApp.EFModel;
using TeleconApp.Interfaces;
using TeleconApp.Models;

namespace TeleconApp.Controllers
{
    [Authorize]
    public class SplicerController : ApplicationBaseController
    {
        private ISplicer _splicer;
        public SplicerController(ISplicer Splicer)
        {
            _splicer = Splicer;
        }
        // GET: Splicer
        public ActionResult Index()
        {
            SplicerModel sm = getSplicerData();
            return View(sm);
        }
        [HttpPost]
        public ActionResult Index(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicer(model);
                model = getSplicerData();
                ViewBag.SplicerSave = "Success";
                return View(model);
            }
            else
            {
                model = getSplicerData();
                return View(model);
            }

        }
        public ActionResult Test()
        {
            SplicerModel sm = getSplicerData();
            return View(sm);
        }
        [HttpPost]
        public ActionResult Test(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicerTest(model);
                model = getSplicerData();
                ViewBag.SplicerSave = "Success";
                return View(model);
            }
            else
            {
                model = getSplicerData();
                return View(model);
            }

        }
        public ActionResult TimeSheet()
        {
            SplicerModel sm = getSplicerData();
            return View(sm);
        }
        [HttpPost]
        public ActionResult TimeSheet(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicerTimesheet(model);
                model = getSplicerData();
                ViewBag.SplicerSave = "Success";
                return View(model);
            }
            else
            {
                model = getSplicerData();
                return View(model);
            }

        }
        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
        private SplicerModel getSplicerData()
        {
            SplicerModel sm = new SplicerModel();
            sm.Employees = _splicer.GetAllEmployees();
            sm.Employees.Sort((x, y) => x.TechName.CompareTo(y.TechName));
            sm.Vehicles = _splicer.GetAllVehicles();
            sm.Vehicles.Sort((x, y) => x.PlateNumber.CompareTo(y.PlateNumber));
            sm.Networks = _splicer.GetAllNetworks();
            sm.Networks.Sort((x, y) => x.BellNetworkNumber.CompareTo(y.BellNetworkNumber));
            sm.Enclosures = _splicer.GetAllEnclosures();
            sm.Enclosures.Sort((x, y) => x.Name.CompareTo(y.Name));
            return sm;
        }
    }
}