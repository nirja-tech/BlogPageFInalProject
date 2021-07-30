using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPageFInalProject.Models
{
    public class SignIn
    {      
        [Required]
        [EmailAddress]
        [Display(Name="EmailID")]
        public string EmailID{ get; set; }

        [Required]
        [Display(Name ="UserName")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }
}
