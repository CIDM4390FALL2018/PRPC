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
using SendGridLib;

namespace SendGridTests
{
    public class SendGridTests
    {

        [Fact]
        //checking to make sure the sender is PRPC
        public void SendTestPass()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("prpc4390@gmail.com"));
            msg.AddTo(new EmailAddress("prpc4390@gmail.com"));
            msg.SetSubject("PRPC Verification Link");
            msg.AddContent(MimeType.Text, "Textual content");
            msg.AddContent(MimeType.Html, "HTML content");

            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"Textual content\"},{\"type\":\"text/html\",\"value\":\"HTML content\"}]}");
            var from = new EmailAddress("prpc4390@gmail.com", "Example User");
            var subject = "PRPC Verification Link";
            var to = new EmailAddress("prpc4390@gmail.com", "Example User");
            var plainTextContent = "plaintextContent!";
            var htmlContent = "<strong>plaintextContent!</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"plaintextContent!\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eplaintextContent!\\u003c/strong\\u003e\"}]}");
         

        }
        //checking that subject is correct
       [Fact]
        public void SendTestPassSubject()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("prpc4390@gmail.com"));
            msg.AddTo(new EmailAddress("prpc4390@gmail.com"));
            msg.SetSubject("PRPC Verification Link");
            //
            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}]}");
            var from = new EmailAddress("prpc4390@gmail.com", "Example User");
            var subject = "PRPC Verification Link";
            var to = new EmailAddress("prpc4390@gmail.com", "Example User");
            var plainTextContent = "plaintextContent!";
            var htmlContent = "<strong>plaintextContent!</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"plaintextContent!\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eplaintextContent!\\u003c/strong\\u003e\"}]}");
         

        }
        //checking that subject is correct -- FAILING TEST
       [Fact]
        public void SendTestFailSubject()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("prpc4390@gmail.com"));
            msg.AddTo(new EmailAddress("prpc4390@gmail.com"));
            msg.SetSubject("PRPC Verification Link");
            //
            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}]}");
            var from = new EmailAddress("prpc4390@gmail.com", "Example User");
            var subject = "PRPC Verification Link";
            var to = new EmailAddress("prpc4390@gmail.com", "Example User");
            var plainTextContent = "plaintextContent!";
            var htmlContent = "<strong>plaintextContent!</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"Not the PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"plaintextContent!\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eplaintextContent!\\u003c/strong\\u003e\"}]}");
         

        }

        
        //a failing test where the sender is not PRPC
        [Fact]
        public void SendTestFail()
        {
            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress("prpc4390@gmail.com"));
            msg.AddTo(new EmailAddress("prpc4390@gmail.com"));
            msg.AddContent(MimeType.Text, "Textual content");
            msg.AddContent(MimeType.Html, "HTML content");

            Assert.True(msg.Serialize() == "{\"from\":{\"email\":\"prpc4390@gmail.com\"},\"personalizations\":[{\"to\":[{\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"Textual content\"},{\"type\":\"text/html\",\"value\":\"HTML content\"}]}");
            var from = new EmailAddress("prpc4390@gmail.com", "Example User");
            var subject = "Sending with SendGrid is not Fun";
            var to = new EmailAddress("prpc4390@gmail.com", "Example User");
            var plainTextContent = "plaintextContent!";
            var htmlContent = "<strong>plaintextContent!</strong>";
            msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            Console.WriteLine(msg.Serialize());

            Assert.True(msg.Serialize() == "{\"from\":{\"name\":\"Example User\",\"email\":\"fakeemail@gmail.com\"},\"personalizations\":[{\"to\":[{\"name\":\"Example User\",\"email\":\"prpc4390@gmail.com\"}],\"subject\":\"PRPC Verification Link\"}],\"content\":[{\"type\":\"text/plain\",\"value\":\"plaintextContent!\"},{\"type\":\"text/html\",\"value\":\"\\u003cstrong\\u003eplaintextContent!\\u003c/strong\\u003e\"}]}");
        

        }

    
        
    }
}