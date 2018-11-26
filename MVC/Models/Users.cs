using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MVC.Models
{
    public class Users
    {
        [Display(Name ="Email")]
        [Required(AllowEmptyStrings =false, ErrorMessage ="Email required")]
        [DataType(DataType.EmailAddress)]

        public int email {get; set;}

        [Display(Name ="First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage ="First name required")]
        public string firstName {get; set;}

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string lastName {get; set;}

        [Required(AllowEmptyStrings =false, ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimum 6 characters required")]
        public string password {get; set;}

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Confirm password and password do not match")]
        public string comfirmpassword {get; set;}

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{8}$")]
        [StringLength(32)]
        [Required(ErrorMessage = "This field is required.")]
        public string phoneNumber {get; set;}
    }
}