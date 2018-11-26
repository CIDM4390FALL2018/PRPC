using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {

        public PRPCRepositoryDbContext Context {get; set;}
        
      
        public PasswordRecovery(){
            //have user enter email --> from email send reset link
            //enters email to find password reset
        }
        public PhoneNumberLookup(){
            //user should get a text from email or name.
           // User.Email == User.PhoneNumber
        }
        public FindUser(){
            //checks email address to see if its used 
            //enter first name last name and get the email address
          //  where(User.FirstName && User.LastName == U)
            if(Email == User.Email
             //
            }
        }
        public CheckPassword(){
            //makes eamil and password match
            if(password == User.Password){
                //successful login take them to manage account page
            }else{
                //alert wrong password, try again, stays on page
            }
        }
        public CheckConfirmation(){
            if(confirmation == true){
                //does something
            }else{
                // does something
            }
            //bool statement
        }
        public PRPCRepository()
        {
            Context = new PRPCRepositoryDbContext();
        }

        public string Hello()
        {
            return "Hello World from PRPCRepository";
        }
    }
}
