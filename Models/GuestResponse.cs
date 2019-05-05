using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsWebMvc.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter your email")]
        [RegularExpression(".+\\@.+\\..+")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your attend")]
        public bool? WillAttend { get; set; }
    }
}
