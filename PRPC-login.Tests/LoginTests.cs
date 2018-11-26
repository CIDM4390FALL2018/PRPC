using System;
using Xunit;
using PRPC.Models;

//using Microsoft.AspNetCore.Mvc;

namespace PRP_Login.Tests
{
    public class LoginTests
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
    }
}