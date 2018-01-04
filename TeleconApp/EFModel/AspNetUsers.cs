using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class AspNetUsers
    {
        [Key]
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string TechName { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
    }
}