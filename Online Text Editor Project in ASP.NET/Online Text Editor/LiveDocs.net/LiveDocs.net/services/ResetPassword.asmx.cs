using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.services
{
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    //Class that handles the reset password functions.
    public class ResetPassword : System.Web.Services.WebService
    {

        [WebMethod]
        public bool SendResetPasswordMail(String email)
        {
            if(!LiveDocs.backend.document.UsernameVerifier.VerifyMail(email))
            {
                return false;
            }
            System.Net.Mail.MailMessage msg = new MailMessage { From = new MailAddress("admin@livedocs.net") };
            msg.To.Add(new MailAddress(email));
            String pwd = backend.Util.GenerateRandomString(8);
            int rowsAffected;
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@mail", email));
                    command.Parameters.Add(new MySqlParameter("@pwd", pwd));
                    command.CommandText = "UPDATE users SET Password = PASSWORD(@pwd) WHERE UserName = @mail LIMIT 1";
                    con.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
                con.Close();
            }
            if (rowsAffected == 1)
            {
                msg.Subject = "LiveDocs.net Password reset";
                msg.Body = "Hello!\n\n" +
                           "" +
                           "Your password was requested to be reset. If this was not done by you, please contact support. \n" +
                           "Your new password is: "+pwd+" \n" +
                           "\n" +
                           "Sincerely,\n" +
                           "The LiveDocs staff";
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.online.no");
                smtp.Send(msg);
                return true;
            }

            return false;
        }
    }
}
