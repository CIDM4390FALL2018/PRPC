using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
		
		//Rebecca's LINQ
		public updateUser(user){
            var queryUser = from user in Users
                            where User.Email = Input.Email
                            select User;
        }
        public updateUser(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false){
                var queryUpdateUser = from user in User
                                    where User.Email = Input.Email
                                    select User;
                            }
        //Luke & Hosu's LINQ
		public updateUser_OnClick(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false)
                {
            var queryNewUser = from Email in Users
                                where Users.Email == //specific user? currently entered email?
                                select Email;

                                User u = queryNewUser; //store current user as the user that has been returned from the database
                                u.FirstName = TextBox1.Text;
                                u.LastName = TextBox2.Text;
                                u.Email = TextBox3.Text;
                                u.Password = TextBox4.Text;
                                u.ConfirmPassword = TextBox5.Text;
                                u.PhoneNumber = TextBox6.Text;
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
		public createuser(user){
                var queryCreateUsers = from user in User        
                                      where User.Email = Input.Email
                                      select User;
        }
        
        public CreateUser(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false){
            var createUserQuery = from user in User
                                where User.Email = null
                                select //something to create user;
                            }
        //Luke & Hosu's LINQ
		public CreateUser_OnClick(string Email, string FirstName, string LastName, 
                            string Password, string ConfirmPassword,
							string PhoneNumber, String Address,
							String City, string State, string ZipCode,
							bool AcceptText = false){

                            User u = new User();  //UserDetails instead of User?
                            u.FirstName = TextBox1.Text;
                            u.LastName = TextBox2.Text;
                            u.Email = TextBox3.Text;
                            u.Password = TextBox4.Text;
                            u.ConfirmPassword = TextBox5.Text;
                            u.PhoneNumber = TextBox6.Text;

                            TrackToolDataContext data = new TrackToolDataContext();
                            data.User.InsertOnSubmit(u);
                            data.SubmitChanges();

                            /* var queryCreateUser = from Email in Users
                                                     where Users.Email = //specific user? currently entered email?
                                                     select Email */
                            }				
		//Rebecca's LINQ
		public deleteUser(user){
                var queryDeleteUser = from User in User
                                      where User.Email = Input.Email    
                                     select User;
        }
        //Rebecca's LINQ
		public deleteUser(string Email){
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