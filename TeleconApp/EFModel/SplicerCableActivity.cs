using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class SplicerCableActivity
    {
        [Key]
        public int Id { get; set; }
        public int SplicerPrepActivityId { get; set; }
        public string CableId { get; set; }
        public int FibreCount { get; set; }
        public bool SplicerPrepped { get; set; }
        public bool SplicerDeRebonized { get; set; }
        public bool SplicerRibbon { get; set; }
        public bool SplicerSingle { get; set; }
        public bool SplicerMissing { get; set; }
    }
}