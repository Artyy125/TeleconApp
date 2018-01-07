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
        public string Foreman { get; set; }
        [Required]
        public string Lead { get; set; }
        public string SavedResult { get; set; }
        public string PlateNumber { get; set; }
        public DateTime? SplicerDate { get; set; }
        public DateTime? SplicerTime { get; set; }
        public string BellNetworkNumber { get; set; }
        public List<string> PartnersName { get; set; }
        public string Enclosure { get; set; }
        public string ARB { get; set; }
        public string SplicerCable1 { get; set; }
        public int SplicerNoFibre1 { get; set; }
        public string SplicerPrepped1 { get; set; }
        public string SplicerDeRebonized1 { get; set; }
        public string SplicerRibbon1 { get; set; }
        public string SplicerSingle1 { get; set; }
        public string SplicerMissing1 { get; set; }
        public string SplicerCable2 { get; set; }
        public int SplicerNoFibre2 { get; set; }
        public string SplicerPrepped2 { get; set; }
        public string SplicerDeRebonized2 { get; set; }
        public string SplicerRibbon2 { get; set; }
        public string SplicerSingle2 { get; set; }
        public string SplicerMissing2 { get; set; }
        public string SplicerCable3 { get; set; }
        public int SplicerNoFibre3 { get; set; }
        public string SplicerPrepped3 { get; set; }
        public string SplicerDeRebonized3 { get; set; }
        public string SplicerRibbon3 { get; set; }
        public string SplicerSingle3 { get; set; }
        public string SplicerMissing3 { get; set; }
        public string SplicerCable4 { get; set; }
        public int SplicerNoFibre4 { get; set; }
        public string SplicerPrepped4 { get; set; }
        public string SplicerDeRebonized4 { get; set; }
        public string SplicerRibbon4 { get; set; }
        public string SplicerSingle4 { get; set; }
        public string SplicerMissing4 { get; set; }
        public string SplicerCable5 { get; set; }
        public int SplicerNoFibre5 { get; set; }
        public string SplicerPrepped5 { get; set; }
        public string SplicerDeRebonized5 { get; set; }
        public string SplicerRibbon5 { get; set; }
        public string SplicerSingle5 { get; set; }
        public string SplicerMissing5 { get; set; }
        public string SplicerCable6 { get; set; }
        public int SplicerNoFibre6 { get; set; }
        public string SplicerPrepped6 { get; set; }
        public string SplicerDeRebonized6 { get; set; }
        public string SplicerRibbon6 { get; set; }
        public string SplicerSingle6 { get; set; }
        public string SplicerMissing6 { get; set; }
        public string SplicerCable7 { get; set; }
        public int SplicerNoFibre7 { get; set; }
        public string SplicerPrepped7 { get; set; }
        public string SplicerDeRebonized7 { get; set; }
        public string SplicerRibbon7 { get; set; }
        public string SplicerSingle7 { get; set; }
        public string SplicerMissing7 { get; set; }
        public DateTime? SplicerEnterTime { get; set; }
        public DateTime? SubmitDate { get; set; }
        public string TestComment { get; set; }
        public string TimeSheetComment { get; set; }
        public string STARB1 { get; set; }
        public string SPTesting1 { get; set; }
        public string STARB2 { get; set; }
        public string SPTesting2 { get; set; }
        public string STARB3 { get; set; }
        public string SPTesting3 { get; set; }
        public string STARB4 { get; set; }
        public string SPTesting4 { get; set; }
        public string STARB5 { get; set; }
        public string SPTesting5 { get; set; }
        public string STARB6 { get; set; }
        public string SPTesting6 { get; set; }
        public string STARB7 { get; set; }
        public string SPTesting7 { get; set; }
        public DateTime? JobStart { get; set; }
        public DateTime? JobFinishAtSite { get; set; }
        public DateTime? ArriveAtShop { get; set; }
        public DateTime? JobFinish { get; set; }
        public DateTime? TimeSheetDate { get; set; }
        public string Odometer { get; set; }


    }
}