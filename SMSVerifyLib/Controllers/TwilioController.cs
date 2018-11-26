using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

//uses <PackageReference Include="Twilio.AspNet.Mvc" Version="5.9.7" /> for mvc

namespace WebApplication1.Controllers

{
    public class SmSController : TwilioController
    {
        public TwiMLResult Index(SmsRequest incomingMessage)
        {
            var messagingResponse = new MessagingResponse();
            string response = incomingMessage.Body.ToUpper(); 

            if(response == "YES")
            {
                //tell DB sms is good
                
                messagingResponse.Message("The copy cat says: " +
                incomingMessage.Body);
            }else if(response == "NO")
            {
                //tell DB not to send sms
                
                messagingResponse.Message("The copy cat says: " +
                incomingMessage.Body);
            }else if(response == "STOP")
            {
                //tell DB not to send sms
                
                messagingResponse.Message("The copy cat says: " +
                incomingMessage.Body);
            }
            return TwiML(messagingResponse);
        }
    }
}