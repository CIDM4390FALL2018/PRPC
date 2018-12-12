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

namespace LoginTests
{

    public class UnitTest1
    {


        [Fact]
       public void PageLoad()
       {
           var controller = new HomeController();
           var viewResult = (ViewResult)controller.Index();
           var viewName = viewResult.ViewName;

           Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
       }
         [Fact]
       public void PageFail()
       {
           throw new NotImplementedException();
        }

        [Fact]
        public void Should_Not_Be_Valid_When_Some_Properties_Incorrect(){
        PRPCUser = new PRPCUser(){

        };

    }
}
}
