using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class SplicerPrepActivity
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int Foreman { get; set; }
        public int Leader { get; set; }
        public int EnclosureId { get; set; }
        public string ARB { get; set; }
        public DateTime JobStart { get; set; }
        public DateTime JobFinishAtSite { get; set; }
        public DateTime ArriveAtShop { get; set; }
        public DateTime JobFinish { get; set; }
        public string Odometer { get; set; }
        public string Comment { get; set; }
        public string PartnerName { get; set; }
        public string BellNetworkNumber { get; set; }
        public string VehiclePlateNumber { get; set; }


    }
}