using System;
using PRPCRepositoryLib.Models;

namespace PRPCRepositoryLib
{
    public class PRPCRepository
    {
        public PRPCRepositoryDbContext Context {get; set;}    
		
		
		public updateUser(user)
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
		
		public createuser(user)
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


            
							
		
		public deleteUser(user){

        }
		public deleteUser(string Email){


            var queryDeleteUser = from Email in Users
                                 where Users.Email =
                                 select Email

                            }
            
        }
		
		
		//PasswordRecoverySMS, PasswordRecoveryEmail, SMS Verification
        public FindUserFromEmail(string Email){
           // find User.Email in user table and return User   
           var queryUsers = from Email in Users      
                            where Users.Email =  
                            select User;
        }
		public FindUserFromPhoneNumber(string PhoneNumber){
           // find User.PhoneNumber in user table and return User   
           var queryUsers = from PhoneNumber in Users
                            where Users.PhoneNumber =
                            select User;
		
        }                   
        public PRPCRepository()
        {
            Context = new PRPCRepositoryDbContext();
        }
    }