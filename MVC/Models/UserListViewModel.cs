using System;
using System.Collections.Generic;
using System.Linq;
using PRPCRepositoryLib;
using PRPCRepositoryLib.Models;

namespace MVC.Models
{
    public class UserListViewModel
    {
        public List<User> Users { get; set; }

        public string RandomCode {get; set; }

        public long Id {get; set; }
        public string Name {get; set;}
        public string Description { get; set; }
        public decimal price { get; set; }
    }
}