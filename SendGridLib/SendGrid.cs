
using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
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
                return Execute( email, subject, message);
            } 
           public Task Execute( string email, string subject, string message)
            {
                var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY"); 
                var client = new SendGridClient(apiKey);
                var msg = new SendGridMessage()
            {
                From = new EmailAddress("prpc4390@gmail.com", "Troy Reeves"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);

            return client.SendEmailAsync(msg); 
        }
    }
            
}

