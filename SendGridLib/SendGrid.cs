using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using dotenv.net;
using System.Security.Cryptography;
using System.Linq;
using System.Text;

namespace SendGridLib
{
        interface IEmailSender
        {
            string email(string userEmail);
            string name (string userName);
        }
        public class EmailSender
        {
            public Task SendEmailAsync(string email, string subject, string message)
            {
                return Execute(subject, message, email);
            } 
           public Task Execute( string subject, string message, string email)
            {
                DotEnv.Config();
                var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
                var client = new SendGridClient(apiKey);
                var msg = new SendGridMessage()
            {
                From = new EmailAddress("troyreeves2@gmail.com", "Joe Smith"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));

            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg); 
        }
        public void PasswordReset(string userEmail, string userName)
            {
                if(userEmail == null){
                Console.WriteLine("Your Email does not exist, please try again");
                }
                else {
                    Execute().Wait();
                    async Task Execute()
                {
                    DotEnv.Config();
                    var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
                    var client = new SendGridClient(apiKey);
            
            
                    //var msg = new SendGridMessage();
                    //msg.SetFrom(new EmailAddress ("troyreeves2@gmail.com", "Troy Reeves"));
                    //msg.AddTo(new EmailAddress(userEmail, userName));
                    //msg.SetTemplateId("d-4838b7f075474bf49db178f80f793c7c");
                    var from = new EmailAddress("troyreeves2@gmail.com", "Example User");
                    var subject = "Password Reset";
                    var to = new EmailAddress(userEmail, userName);
                    var plainTextContent = "Click the link to reset password";
                    var htmlContent = "Please click this link to reset your password. Link:" ;
                    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                    var response = await client.SendEmailAsync(msg);
                }
            }
        }
            
    }
}
