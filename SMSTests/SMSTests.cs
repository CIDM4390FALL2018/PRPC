using System;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Xml;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using smsverifylibrary;

namespace SMSTests
{
    //making sure response to text message is a string
    //based off code from twilio official github page
        public class TwiMLResultTests
    {
        //strings n such
        public const string AsciiChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
        public const string UnicodeChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890äåéö";        

        //string constructor
        [Fact]
        public void TestStringDefaultEncodingPass()
        {
            var responseString = GetGetMessagingResponse(UnicodeChars).ToString();

            var result = new TwiMLResult(responseString);

            Assert.Contains(UnicodeChars, result.Data.ToString());
        }

        [Fact]
        public void TestStringAsciiEncodingFail()
        {
            var responseString = GetGetMessagingResponse(UnicodeChars).ToString();

            var result = new TwiMLResult(responseString, Encoding.ASCII);

            Assert.Contains(AsciiChars, result.Data.ToString());
            Assert.DoesNotContain(UnicodeChars, result.Data.ToString());
        }

        [Fact]
        public void TestStringUnicodeEncodingUtf8()
        {
            var responseString = GetGetMessagingResponse(UnicodeChars).ToString();

            var result = new TwiMLResult(responseString, Encoding.UTF8);

            Assert.Contains(UnicodeChars, result.Data.ToString());
        }

        //messaging response constructor
        [Fact]
        public void TestGetMessagingResponseDefaultEncodingPass()
        {
            var response = GetGetMessagingResponse(UnicodeChars);

            var result = new TwiMLResult(response);

            Assert.Contains(UnicodeChars, result.Data.ToString());
        }

        [Fact]
        public void TestGetMessagingResponseAsciiEncodingFail()
        {
            var response = GetGetMessagingResponse(UnicodeChars);

            var result = new TwiMLResult(response, Encoding.ASCII);

            Assert.Contains(AsciiChars, result.Data.ToString());
            Assert.DoesNotContain(UnicodeChars, result.Data.ToString());
        }

        [Fact]
        public void TestGetMessagingResponseUnicodeEncodingUtf8()
        {
            var response = GetGetMessagingResponse(UnicodeChars);

            var result = new TwiMLResult(response, Encoding.UTF8);

            Assert.Contains(UnicodeChars, result.Data.ToString());
        }

        [Fact]
        public void TestGetMessagingResponseExplicitDefaultEncodingFail()
        {
            var response = GetGetMessagingResponse(UnicodeChars);

            Assert.Throws<XmlException>(() =>
            {
                new TwiMLResult(response, Encoding.Default);
            });
        }

        public TwiML.GetMessagingResponse GetGetMessagingResponse(string content)
        {
            return new TwiML.GetMessagingResponse().Say(content);
        }
    }
    public class TwilioControllerTests
    {

        [Fact]
        public void TestMessagingResponseDefaultEncodingPass()
        {
            var response = GetMessagingResponse(TwiMLResultTests.UnicodeChars);

            var result = new TwilioController().TwiML(response);

            Assert.Contains(TwiMLResultTests.UnicodeChars, result.Data.ToString());
        }

        private static TwiML.MessagingResponse GetMessagingResponse(string content)
        {
            return new TwiML.MessagingResponse().Message(content);
        }
    }

}
