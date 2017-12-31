using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class Network
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string BellNetworkNumber { get; set; }

        [MaxLength(3)]
        public string MaxARB { get; set; }

        [MaxLength(20)]
        public string UtilityCutPermit { get; set; }

        [MaxLength(20)]
        public string PermitTypeStream { get; set; }

        [MaxLength(50)]
        public string LocationName { get; set; }

        [MaxLength(20)]
        public string District { get; set; }
    }
}