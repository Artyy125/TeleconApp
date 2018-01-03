using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeleconApp.EFModel
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "Please enter a name less than 101 characters")]
        [RegularExpression(@"^[a-zA-Z ]*$")]
        public string TechName { get; set; }

        [MaxLength(12, ErrorMessage = "Please enter a phone number less than 13 digits")]
        [RegularExpression(@"^[0-9]*$")]
        public string PhoneNumber { get; set; }

        [MaxLength(500)]
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
    }
}