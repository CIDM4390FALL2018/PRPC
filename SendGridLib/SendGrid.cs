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
        interface ISMTP
        {
            string email(string userEmail);
            string name (string userName);
        }
        
        public class EmailConfirmation
        {
            public static string NewToken()
            {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] randomBuffer = new byte[16];
                rng.GetBytes(randomBuffer);

            using (MD5 md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(randomBuffer);

                StringBuilder sBuilder = new StringBuilder();
                foreach (byte byt in hashBytes)
            {
                sBuilder.Append(byt.ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}


            /* public string UrlGenerator(int uniqueId){
            {   
                const string availableChars =
                    "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                
                using (var generator = new RNGCryptoServiceProvider())
                {
                    var bytes = new byte [16];
                    generator.GetBytes(bytes);
                    var chars = bytes 
                        .Select(b => availableChars[b % availableChars.Length]);
                    var token = new string (chars.ToArray());
                    return uniqueId + token;
                }
            }
            }*/
            public void VerifyEmail(string userEmail, string userName)
            {
            Execute().Wait();

             async Task Execute()
            {
            DotEnv.Config();
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            

            var msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress ("troyreeves2@gmail.com", "Troy Reeves"));
            msg.AddTo(new EmailAddress(userEmail, userName));
            msg.SetTemplateId("d-c99a05d84f8649a9a72ea35ae78b20b4");
            //var from = new EmailAddress("troyreeves2@gmail.com", "Example User");
            //var subject = "Welcome To SendGrid";
            //var to = new EmailAddress("troyreeves2@gmail.com", "Example User");
            //var plainTextContent = "and easy to do anywhere, even with C#";
            //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
            }
           
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
                    var htmlContent = "Please click this link to reset your password. Link:" + NewToken();
                    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                    var response = await client.SendEmailAsync(msg);
                }
            }
        }
            
    }
} 
