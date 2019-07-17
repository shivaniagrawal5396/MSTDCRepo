using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSTDC.Models
{
    public class Signup
    {
        [Required]
        public string Name { get; set; }
        [Required]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
     
        public string Gender { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }
    }
}