using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Security.Cryptography;
using System.Text;

using PRPCRepositoryLib;
using PRPCRepositoryLib.Models;


namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        //private PRPCRepository repo;

        public HomeController()
        {
            //repo = new PRPCRepository();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(){
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult ForgotPassword()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult About()
        {
           /*  int length = 6;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
    {
        while (s.Length != length)
        {
            byte[] oneByte = new byte[1];
            provider.GetBytes(oneByte);
            char character = (char)oneByte[0];
            if (valid.Contains(character))
            {
                s += character;
            }
            }
                ViewBag.MyString = s;

             UserListViewModel cap = new UserListViewModel
            {
                Id = 1,
                Name = "Golf cap",
                Description = "A nice cap to play golf",
                price = 10m
            };
 
            ViewData["MyProduct"] = cap; */
 
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ProveIt()
        {

            UserListViewModel vm = new UserListViewModel();
            PRPCRepository repo = new PRPCRepository();

            using(repo.Context = new PRPCRepositoryDbContext())
            {

                vm.Users = repo.Context.Users.ToList();
            }

            int length = 6;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
    {
        while (s.Length != length)
        {
            byte[] oneByte = new byte[1];
            provider.GetBytes(oneByte);
            char character = (char)oneByte[0];
            if (valid.Contains(character))
            {
                s += character;
            }
            }
                ViewBag.MyString = s;
            return View(vm);
        }
        }
    

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

       
/* public ActionResult GetRandomCode(int length)
{
     const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
     StringBuilder res = new StringBuilder();

    using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
    {
        byte[] uintBuffer = new byte[sizeof(uint)];

        while (length-- > 0)
        {
            rng.GetBytes(uintBuffer);
            uint num = BitConverter.ToUInt32(uintBuffer, 0);
            res.Append(valid[(int)(num % (uint)valid.Length)]);
        }
    }
    ViewData["RandomCode"] = res;

    return View(); 
}*/
    }
}