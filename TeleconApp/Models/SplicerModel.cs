using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public int Id { get; set; }
        [Required]
        public string TechName { get; set; }
        [Required]
        public string ForemanName { get; set; }
        [Required]
        public string LeadName { get; set; }
        [Required]
        public string PlateNumber { get; set; }
    }
}