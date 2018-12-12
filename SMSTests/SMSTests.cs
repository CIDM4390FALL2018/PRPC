using System;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using smsverifylibrary;

namespace SMSTests
{
    public class UnitTest1
    {
        public const string AsciiChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        public const string UnicodeChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890äåéö";
     
        [Fact]
        public void TestStringPassing()
        {
               var responseString = GetVoiceResponse(UnicodeChars).ToString();
                var result = new TwiMLResult(responseString);
                Assert.Contains(UnicodeChars, result.Data.ToString());
        }
        [Fact]
        public void TestStringFailing()
        {
            var responseString = GetVoiceResponse(UnicodeChars).ToString();
            var result = new TwiMLResult(responseString, Encoding.ASCII);
            Assert.Contains(AsciiChars, result.Data.ToString());
            Assert.DoesNotContain(UnicodeChars, result.Data.ToString());
}
 
    }
}
