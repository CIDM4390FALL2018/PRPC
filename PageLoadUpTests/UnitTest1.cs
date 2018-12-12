using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Moq;
using MVC.Controllers;
using MVC.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Microsoft.Extensions.Options;
using MVC.Areas.Identity.Pages.Account.Manage;

namespace PageLoadUpTests
{
    //expected result passed 2 failed 1
  public class UnitTest1
    {

        //startup test to validate pages load
        [Fact]
       public void PageLoad()
       {
           var controller = new HomeController();
           var viewResult = (ViewResult)controller.Index();
           var viewName = viewResult.ViewName;

           Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
       }
       //failing test if pages don't load
         [Fact]
       public void PageFail()
       {
           throw new NotImplementedException();
        }

        [Fact]
        public void Should_Not_Be_Valid_When_Some_Properties_Incorrect(){
       // var user = (){
      //  var user = await userManager.FindByNameAsync(PRPCUser.Fname.Name); 
        //};

    }
}
}
