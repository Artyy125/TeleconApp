using Microsoft.AspNet.Identity;
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
            int empId = Convert.ToInt32(User.Identity.Name);
            sm = GetSavedPrepActivity(empId, sm);
            return View(sm);
        }
        [HttpPost]
        public ActionResult Index(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicer(model);
                SplicerModel sm = getSplicerData();
                model.Employees = sm.Employees;
                model.Vehicles = sm.Vehicles;
                model.Networks = sm.Networks;
                model.Enclosures = sm.Enclosures;
                //model = getSplicerData();
                //ViewBag.SplicerSave = "Success";
                model.SavedResult = "Your data was saved!";
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
            int empId = Convert.ToInt32(User.Identity.Name);
            sm = GetSavedPrepActivity(empId, sm);
            return View(sm);
        }
        [HttpPost]
        public ActionResult Test(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicerTest(model);
                SplicerModel sm = getSplicerData();
                model.Employees = sm.Employees;
                model.Vehicles = sm.Vehicles;
                model.Networks = sm.Networks;
                model.Enclosures = sm.Enclosures;
                model.SavedResult = "Your data was saved!";
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
            int empId = Convert.ToInt32(User.Identity.Name);
            sm = GetSavedPrepActivity(empId, sm);
            return View(sm);
        }
        [HttpPost]
        public ActionResult TimeSheet(SplicerModel model)
        {
            if (ModelState.IsValid)
            {
                int id = _splicer.SaveSplicerTimesheet(model);
                SplicerModel sm = getSplicerData();
                model.Employees = sm.Employees;
                model.Vehicles = sm.Vehicles;
                model.Networks = sm.Networks;
                model.Enclosures = sm.Enclosures;
                model.SavedResult = "Your data was saved!";
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
        private SplicerModel GetSavedPrepActivity(int employeeId,SplicerModel data)
        {
            try
            {
                SplicerModel result = _splicer.GetSplicerPrepActivity(Convert.ToInt32(User.Identity.Name));
                if (result != null)
                {
                    data.TechName = result.TechName;
                    data.Lead = result.Lead;
                    data.PlateNumber = result.PlateNumber;
                    data.BellNetworkNumber = result.BellNetworkNumber;
                    data.Foreman = result.Foreman;
                }
                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}