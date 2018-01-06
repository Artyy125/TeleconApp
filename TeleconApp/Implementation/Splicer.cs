using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TeleconApp.EFModel;
using TeleconApp.Interfaces;
using TeleconApp.Models;

namespace TeleconApp.Implementation
{
    public class Splicer : ISplicer
    {
        private TeleconDbContext _db;
        public Splicer()
        {
            _db = new TeleconDbContext();
        }
        public List<EmployeeModel> GetAllEmployees()
        {
            try
            {
                List<EmployeeModel> employees = _db.AspNetUsers.Select(r => new EmployeeModel
                {
                    Id = r.EmployeeId,
                    TechName = r.TechName
                }).ToList();
                return employees;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
        }
        public List<VehicleModel> GetAllVehicles()
        {
            try
            {
                List<VehicleModel> vehicles = _db.Vehicles.Select(r => new VehicleModel
                {
                    Id = r.Id,
                    PlateNumber = r.PlateNumber,
                    Type = r.Type,
                    UnitId = r.UnitId
                }).ToList();
                return vehicles;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
        }
        public List<NetworkModel> GetAllNetworks()
        {
            try
            {
                List<NetworkModel> networks = _db.Networks.Select(r => new NetworkModel
                {
                    Id = r.Id,
                    BellNetworkNumber = r.BellNetworkNumber,
                    District = r.District,
                    LocationName = r.LocationName,
                    MaxARB = r.MaxARB,
                    PermitTypeStream = r.PermitTypeStream,
                    UtilityCutPermit = r.UtilityCutPermit
                }).ToList();
                return networks;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
        }
        public List<EnclosureModel> GetAllEnclosures()
        {
            try
            {
                List<EnclosureModel> enclosures = _db.Enclosures.Select(r => new EnclosureModel
                {
                    Id = r.Id,
                    Name = r.Name
                }).ToList();
                return enclosures;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
        }
        public int SaveSplicer(SplicerModel model)
        {
            try
            {
                SplicerPrepActivity activity = new SplicerPrepActivity();
                activity.EmployeeId = model.Id;
                activity.Foreman = model.Foreman;
                activity.Leader = model.Lead;
                activity.VehiclePlateNumber = model.PlateNumber;
                activity.PrepSubmitDate = DateTime.Now;
                activity.CableTodayJobDoneDate = model.SplicerDate;
                activity.CableOnDutyTime = model.SplicerTime;
                activity.CableBellNetworkNumber = model.BellNetworkNumber;
                string partners = "";
                string lastItem = model.PartnersName.Last();
                foreach (var item in model.PartnersName)
                {
                    if (item != lastItem)
                    {
                        partners = partners + item + ",";
                    }
                    else
                    {
                        partners = partners + item;
                    }
                }
                activity.CablePartnerName = partners;
                activity.PreparationTime = model.SplicerEnterTime;
                _db.SplicerPrepActivities.Add(activity);
                _db.SaveChanges();
                int id = activity.Id;
                if (model.SplicerCable1?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable1;
                    cableActivity.FibreCount = model.SplicerNoFibre1;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized1 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing1 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped1 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon1 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle1 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable2?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable2;
                    cableActivity.FibreCount = model.SplicerNoFibre2;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized2 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing2 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped2 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon2 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle2 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable3?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable3;
                    cableActivity.FibreCount = model.SplicerNoFibre3;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized3 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing3 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped3 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon3 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle3 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable4?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable4;
                    cableActivity.FibreCount = model.SplicerNoFibre4;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized4 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing4 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped4 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon4 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle4 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable5?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable5;
                    cableActivity.FibreCount = model.SplicerNoFibre5;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized5 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing5 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped5 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon5 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle5 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable6?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable6;
                    cableActivity.FibreCount = model.SplicerNoFibre6;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized6 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing6 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped6 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon6 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle6 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                if (model.SplicerCable7?.Trim() != "")
                {
                    SplicerCableActivity cableActivity = new SplicerCableActivity();
                    cableActivity.CableId = model.SplicerCable7;
                    cableActivity.FibreCount = model.SplicerNoFibre7;
                    cableActivity.SplicerDeRebonized = model.SplicerDeRebonized7 == "on" ? true : false;
                    cableActivity.SplicerMissing = model.SplicerMissing7 == "on" ? true : false;
                    cableActivity.SplicerPrepped = model.SplicerPrepped7 == "on" ? true : false;
                    cableActivity.SplicerRibbon = model.SplicerRibbon7 == "on" ? true : false;
                    cableActivity.SplicerSingle = model.SplicerSingle7 == "on" ? true : false;
                    cableActivity.SplicerPrepActivityId = id;
                    _db.SplicerCableActivities.Add(cableActivity);
                }
                _db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {

                string error = ex.Message;
                throw;
            }
        }
        public int SaveSplicerTest(SplicerModel model)
        {
            try
            {
                SplicerPrepActivity result = _db.SplicerPrepActivities.Where(r => r.EmployeeId == model.Id).FirstOrDefault();
                int id = 0;
                SplicerPrepActivity activity = new SplicerPrepActivity();
                if (result == null)
                {
                    activity.EmployeeId = model.Id;
                    activity.Foreman = model.Foreman;
                    activity.Leader = model.Lead;
                    activity.VehiclePlateNumber = model.PlateNumber;
                    activity.TestSubmitDate = DateTime.Now;
                    activity.TestTodayJobDoneDate = model.SplicerDate;
                    activity.TestOnDutyTime = model.SplicerTime;
                    activity.CableBellNetworkNumber = model.BellNetworkNumber;
                    string partners = "";
                    string lastItem = model.PartnersName.Last();
                    foreach (var item in model.PartnersName)
                    {
                        if (item != lastItem)
                        {
                            partners = partners + item + ",";
                        }
                        else
                        {
                            partners = partners + item;
                        }
                    }
                    activity.TestPartnerName = partners;
                    activity.TestCompletedTime = model.SplicerEnterTime;
                    _db.SplicerPrepActivities.Add(activity);
                    _db.SaveChanges();
                }
                id = activity.Id;
                if (model.STARB1.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB1;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting1;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB2?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB2;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting2;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB3?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB3;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting3;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB4?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB4;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting4;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB5?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB5;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting5;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB6?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB6;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting6;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                if (model.STARB7?.Trim() != "")
                {
                    SplicerTestActivity testActivity = new SplicerTestActivity();
                    testActivity.ARB = model.STARB7;
                    testActivity.SplicerPrepActivityId = id;
                    testActivity.SplicerTestName = model.SPTesting7;
                    _db.SplicerTestActivities.Add(testActivity);
                }
                _db.SaveChanges();
                return id;
            }
            catch (Exception ex)
            {

                string error = ex.Message;
                throw;
            }
        }
        public int SaveSplicerTimesheet(SplicerModel model)
        {
            try
            {
                SplicerPrepActivity result = _db.SplicerPrepActivities.Where(r => r.EmployeeId == model.Id).FirstOrDefault();

                int id = 0;
                SplicerPrepActivity activity = new SplicerPrepActivity();
                if (result.PrepSubmitDate.Date != DateTime.Now.Date)
                {
                    activity.EmployeeId = model.Id;
                    activity.Foreman = model.Foreman;
                    activity.Leader = model.Lead;
                    activity.VehiclePlateNumber = model.PlateNumber;
                    activity.TimeSheetSubmitDate = DateTime.Now;
                    _db.SplicerPrepActivities.Add(activity);
                    _db.SaveChanges();
                }
                activity.TimeSheetComment = model.TimeSheetComment;
                activity.JobStart = model.JobStart;
                activity.JobFinish = model.JobFinish;
                activity.JobFinishAtSite = model.JobFinishAtSite;
                activity.ArriveAtShop = model.ArriveAtShop;
                activity.TimeSheetDate = model.TimeSheetDate;
                activity.Odometer = model.Odometer;
                _db.SaveChanges();
                id = activity.Id;
                return id;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }
        }
    }
}