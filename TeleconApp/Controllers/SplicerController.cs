using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
            SplicerModel sm = new SplicerModel();
            sm.Employees = _splicer.GetAllEmployees();
            sm.Vehicles = _splicer.GetAllVehicles();
            sm.Networks = _splicer.GetAllNetworks();
            sm.Enclosures = _splicer.GetAllEnclosures();
            return View(sm);
        }
        public ActionResult Test()
        {
            SplicerModel sm = new SplicerModel();
            sm.Employees = _splicer.GetAllEmployees();
            sm.Vehicles = _splicer.GetAllVehicles();
            sm.Networks = _splicer.GetAllNetworks();
            sm.Enclosures = _splicer.GetAllEnclosures();

            return View(sm);
        }
        public ActionResult TimeSheet()
        {
            SplicerModel sm = new SplicerModel();
            sm.Employees = _splicer.GetAllEmployees();
            sm.Vehicles = _splicer.GetAllVehicles();
            return View(sm);
        }
    }
}