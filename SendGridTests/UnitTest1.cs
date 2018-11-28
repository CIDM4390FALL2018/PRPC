using System;
using Xunit;
using Xunit.Abstractions;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using dotenv.net;
using System.Security.Cryptography;
using System.Linq;

namespace SendGridTests
{
    public class UnitTest1
    {
        [Fact]
        public void SendTestPass()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("test@example.com"));
            msg.AddTo(new EmailAddress("test@example.com"));
            msg.SetSubject("Hello World from unit test");
            msg.AddContent(MimeType.Text, "Textual content");
            msg.AddContent(MimeType.Html, "HTML content");

            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"test@example.com\"},\"personalizations\":[{\"to\":[{\"email\":\"test@example.com\"}],\"subject\":\"Hello World from unit test\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"Textual content\"},{\"type\":\"text/html\",\"value\":\"HTML content\"}]}");
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"test@example.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"test@example.com\"}],\"subject\":\"Sending with SendGrid is Fun\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"and easy to do anywhere, even with C#\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eand easy to do anywhere, even with C#\\u003c/strong\\u003e\"}]}");
        

        }
        //a failing test
        [Fact]
        public void SendTestFail()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("test@example.com"));
            msg.AddTo(new EmailAddress("test@example.com"));
            msg.SetSubject("Goodbye World from unit test");
            msg.AddContent(MimeType.Text, "Textual content");
            msg.AddContent(MimeType.Html, "HTML content");

            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"test@example.com\"},\"personalizations\":[{\"to\":[{\"email\":\"test@example.com\"}],\"subject\":\"Hello World from unit test\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"Textual content\"},{\"type\":\"text/html\",\"value\":\"HTML content\"}]}");
            var from = new EmailAddress("test@example.com", "Example User");
            var subject = "Sending with SendGrid is not Fun";
            var to = new EmailAddress("test@example.com", "Example User");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"test@example.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"test@example.com\"}],\"subject\":\"Sending with SendGrid is Fun\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"and easy to do anywhere, even with C#\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eand easy to do anywhere, even with C#\\u003c/strong\\u003e\"}]}");
        

        }
    }
}
