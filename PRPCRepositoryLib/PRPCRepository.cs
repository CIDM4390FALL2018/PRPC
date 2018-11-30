using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
		
		
		public updateUser(user)
		public updateUser(string Email, string FirstName, string LastName, 
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false)
{
            var queryNewUser = from Email in Users
                                where Users.Email == //something
                                select Email;
}
		
		public createuser(user){

        }
		public createuser(string Email, string FirstName, string LastName, 
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false){


                            var queryCreateUser = from Email in Users
                                                     where Users.Email 
                                                     select Email
                            }


            
							
		
		public deleteUser(user){

        }
		public deleteUser(string Email){


            var queryDeleteUser = from Email in Users
                                 where Users.Email 
                                 select Email

                            }
            
        }
		
		
		//PasswordRecoverySMS, PasswordRecoveryEmail, SMS Verification
        public FindUserFromEmail(string Email){
           // find User.Email in user table and return User   
           var queryUsers = from Email in Users        
                            select User;
        }
		public FindUserFromPhoneNumber(string PhoneNumber){
           // find User.PhoneNumber in user table and return User   
        }
		
        public PRPCRepository()
        {
            Context = new PRPCRepositoryDbContext();
        }
    }
}