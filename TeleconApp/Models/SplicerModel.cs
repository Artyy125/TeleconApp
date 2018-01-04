using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeleconApp.Models
{
    public class SplicerModel
    {
        public List<EmployeeModel> Employees { get; set; }
        public List<VehicleModel> Vehicles { get; set; }
        public List<NetworkModel> Networks { get; set; }
        public List<EnclosureModel> Enclosures { get; set; }
    }
}