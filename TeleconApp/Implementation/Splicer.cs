﻿using System;
using System.Collections.Generic;
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
    }
}