using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
//using System.Data.EntityFrameworkCore;

namespace MVC.Models
{
    public class LoginViewModel
    {
        //public string userName {get; set;}

        //public bool userName => !string.IsNullOrEmpty(RequestuserName);

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }
        

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Password")]
        public string passWord { get; set; }

        [Display(Name = "Email address")]
        [StringLength(60, MinimumLength = 7)]
        public string emailAddress { get; set; }

        
    } 
}