using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class SplicerTestActivity
    {
        [Key]
        public int Id { get; set; }
        public int SplicerPrepActivityId { get; set; }
        public string ARB { get; set; }
        public bool GLB { get; set; }
        public bool AerialRoadSide { get; set; }
        public bool AerialBackyard { get; set; }
        public bool Pedestal { get; set; }
        public bool ReBurn { get; set; }
        
        
        

    }
}