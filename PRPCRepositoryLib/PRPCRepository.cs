using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
        public Registration(){
            if(Email != User.Email){
                return true;
            }else{
                return false;
            }
        }
        public PasswordRecovery(){
            //have user enter email --> from email send reset link
            //enters email to find password reset
           // find(User.Email){
                //send reset link to email
            if(email == User.Email){
                return true;
            }else{
                return false;
            }
        }
        public PhoneNumberLookup(){
            //user should get a text from email or name.
           // User.Email == User.PhoneNumber
           if(PhoneNumber == User.PhoneNumber){
               return true;
           }else{
               return false;
           }
        }
        public FindUser(){
            //checks email address to see if its used 
            //enter first name last name and get the email address
          //  where(User.FirstName && User.LastName == U)
            if(Email == User.Email){
             return User.FirstName;
            }
        }
        public CheckPassword(){
            //makes eamil and password match
            if(password == User.Password){
                return true;
            }else{
                return false;
            }
        }
        public CheckConfirmation(){
            if(confirmation == true){
                return true;
            }else{
                return false;
            }
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
