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
        public string TechName { get; set; }
        public string Foreman { get; set; }
        public string Leader { get; set; }
        public string EnclosureId { get; set; }
        public string ARB { get; set; }
        public DateTime? JobStart { get; set; }
        public DateTime? JobFinishAtSite { get; set; }
        public DateTime? ArriveAtShop { get; set; }
        public DateTime? JobFinish { get; set; }
        public DateTime? TimeSheetDate { get; set; }
        public DateTime? PreparationTime { get; set; }
        public string Odometer { get; set; }
        public string TimeSheetComment { get; set; }
        public string VehiclePlateNumber { get; set; }
        public DateTime? PrepSubmitDate { get; set; }
        public DateTime? TimeSheetSubmitDate { get; set; }
        public DateTime? TestSubmitDate { get; set; }
        public string TestComment { get; set; }
        public string TestPartnerName { get; set; }
        public string TestBellNetworkNumber { get; set; }
        public DateTime? TestCompletedTime { get; set; }
        public DateTime? TestTodayJobDoneDate { get; set; }
        public DateTime? TestOnDutyTime { get; set; }
        public DateTime? CableCompletedTime { get; set; }
        public DateTime? CableTodayJobDoneDate { get; set; }
        public DateTime? CableOnDutyTime { get; set; }
        public string CablePartnerName { get; set; }
        public string CableBellNetworkNumber { get; set; }


    }
}