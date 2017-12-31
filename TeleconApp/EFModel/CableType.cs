using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class CableType
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        public int FibreCount { get; set; } 
    }
}