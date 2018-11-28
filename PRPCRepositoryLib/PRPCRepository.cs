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


/*1. O-Auth
    Need to pull the intended email address to see if there is an outside authentication resource (i.e facebook) and return a True or False value.
2. Read Receive Text Messages
    Need to pull intended phone number and return a message to be sent to the user.
3. Two Factor Auth: SMS
    Need to pull intended phone number or email address and return a randomly generated 6-digit code to be sent to the user.
4. Password Recovery SMS
    Need to pull the intended phone number and return a link to be sent to the user's phone number to reset password.
5. Password Recovery Email
Need to pull the intended user's email and return a link to be sent to the user's email address to reset password.
6. Change Password Database Update (generates password and writes to database)
    Need to pull intended user's email address, create a randomly generated password, and returns a new password to the database.*/
