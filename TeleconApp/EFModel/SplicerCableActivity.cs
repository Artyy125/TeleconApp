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
        public int SplcerPrepActivityId { get; set; }
        public string CableId { get; set; }
        public int FibreCount { get; set; }
        public string Action { get; set; }
        public DateTime CompletedTime { get; set; }
    }
}