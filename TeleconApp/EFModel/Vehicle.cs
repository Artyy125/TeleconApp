using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string PlateNumber { get; set; }

        [MaxLength(50)]
        public string UnitId { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

    }
}