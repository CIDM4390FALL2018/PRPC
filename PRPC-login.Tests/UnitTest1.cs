using System;
using Xunit;
using PRPC.Models;

namespace PRPC_Login.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanLogIn()
        {
            LoginProvider providerTest = new LoginProvider();

            var type = providerTest.GetType();
            //
            PasswordVerify("username", "passsword");
            bool isValid = ValidateUser("username", "password");
            Assert.IsTrue(isValid);

        }
    }
}
