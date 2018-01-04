using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.Models
{
    public class EnclosureModel
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}