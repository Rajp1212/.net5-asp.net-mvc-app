using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proj3_Patel.Models
{
    public class RegisteredUser
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        [Range(18, 100, ErrorMessage = "Please enter age between 18 to 100")]
        public string Age { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Hey! Your password don't match!")]
        public string PasswordConfirm { get; set; }
        public string Degree { get; set; }

        public string University { get; set; }

        public string IsSubscribing { get; set; }

        public string Gender { get; set; }
    }
}
