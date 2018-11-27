using System;
using System.ComponentModel.DataAnnotations;

namespace PRPCRepositoryLib.Models
{
    public class User
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        [Key]
        public string Email {get; set;}
        public string Password {get; set;}
        public string ConfirmPassword { get; set; }
        public string PhoneNumber {get; set;}
    }
}