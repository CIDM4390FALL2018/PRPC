using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using SendGrid;
using Microsoft.AspNetCore.Identity;
using MVC.Areas.Identity.Data;
using SendGridLib;

namespace MVC.Controllers
{
    public class EmailTestController : Controller
    {
        private readonly UserManager<PRPCUser> _manager;
        public EmailTestController(UserManager<PRPCUser> userManager){
            _manager = userManager;
        } 
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            PRPCUser user = await GetCurrentUserAsync();
            EmailSender email = new EmailSender();
            ViewData["name"] = user.FName;
            ViewData["email"] = user.Email;
            ViewData["messageResult"] = email.SendEmailAsync(user.Email, user.FName, message:"confirm");
           
            return View();
            //try async
        }

        private Task<PRPCUser> GetCurrentUserAsync() => _manager.GetUserAsync(HttpContext.User);

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}