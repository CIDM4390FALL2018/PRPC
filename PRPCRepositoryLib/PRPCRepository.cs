using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
		
		//Rebecca's LINQ
		public UpdateUser(user){
            var queryUser = from user in Users
                            where User.Email = Input.Email
                            select User;
        }
        public UpdateUser(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, string Address,
							string City, string State, string ZipCode,
							bool AcceptText = false){
                var QueryUpdateUser = from user in User
                                    where User.Email = Input.Email
                                    select User;
                            }
        //Luke & Hosu's LINQ
		public UpdateUser_OnClick(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, string Address,
							string City, string State, string ZipCode,
							bool AcceptText = false)
                {
            var queryNewUser = from Email in Users
                                where Users.Email == //specific user? currently entered email?
                                select Email;

                                
            //submit changes
            try{
                db.SubmitChanges();
            }
            catch(Exception e){
                Console.WriteLine(e);
                //provide exceptions
            }
}
//Rebecca's LINQ statement
		public Createuser(User){
                var queryCreateUsers = from user in Users        
                                      where User.Email = Input.Email
                                      select User;
        }
        
        public CreateUser(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, string Address,
							string City, string State, string ZipCode,
							bool AcceptText = false){
            var createUserQuery = from user in User
                                where User.Email = null
                                select //something to create user;
                            }
        //Luke & Hosu's LINQ
		public CreateUser_OnClick(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, string Address,
							string City, string State, string ZipCode,
							bool AcceptText = false){

                           

                            TrackToolDataContext data = new TrackToolDataContext();
                            data.User.InsertOnSubmit(u);
                            data.SubmitChanges();

                            /* var queryCreateUser = from Email in Users
                                                     where Users.Email = //specific user? currently entered email?
                                                     select Email */
                            }				
		//Rebecca's LINQ
		public DeleteUser(user){
                var queryDeleteUser = from User in User
                                      where User.Email = Input.Email    
                                     select User;
        }
        //Rebecca's LINQ
		public DeleteUser(string Email){
            var queryDeleteUser = from Email in User
                                 where Users.Email = Input.Email
                                 select User;
                            }
        }		
		//PasswordRecoverySMS, PasswordRecoveryEmail, SMS Verification
        //Rebecca's LINQ
        public FindUserFromEmail(string Email){
           // find User.Email in user table and return User   
           var queryUserFromEmail = from Email in Users      
                            where User.Email =  
                            select User;
        }
        //Rebecca's LINQ
		public FindUserFromPhoneNumber(string PhoneNumber){
           // find User.PhoneNumber in user table and return User   
           var queryUserFromPhoneNumber = from PhoneNumber in User
                            where User.PhoneNumber = Input.PhoneNumber
                            select User;
		
        }                   
        public PRPCRepository()
        {
            Context = new PRPCRepositoryDbContext();
        }
    }