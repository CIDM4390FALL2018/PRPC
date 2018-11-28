using dotenv.net;
using SendGridLib;
namespace PRPC_1
{
    class Program
    {
        static void Main(string[] args)
        {   
            DotEnv.Config();
            EmailConfirmation converter = new EmailConfirmation();
            converter.PasswordReset(userEmail:"troyreeves2@gmail.com",userName: "troy");
        }
}
}