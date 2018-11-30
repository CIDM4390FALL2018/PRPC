using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
		
		
		public updateUser(user)
		public updateUser(string email, string fname, string lname, 
							string PhoneNumber, String address,
							String City, string State, string ZipCode,
							bool acceptText = false)
		
		public createuser(user)
		public createuser(string email, string fname, string lname, 
							string PhoneNumber, String address,
							String City, string State, string ZipCode,
							bool acceptText = false)
							
		
		public deleteUser(user)
		public deleteUser(string email)
		
		
		//PasswordRecoverySMS, PasswordRecoveryEmail, SMS Verification
        public FindUserFromEmail(string email){
           // find User.Email in user table and return User   
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