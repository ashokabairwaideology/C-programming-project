using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;


public class UserDAL
{
	public static User Login(string email, string pwd)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select uid, fullname, occupation from users where email = @email and pwd = @pwd", con);
            cmd.Parameters.Add("@email",SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 10).Value = pwd;
            SqlDataReader dr = cmd.ExecuteReader();
            if ( dr.Read()) {
                 User u = new User(  dr["uid"].ToString(), email, dr["fullname"].ToString(), dr["occupation"].ToString() );
                 return u;
            }
            else
                return null;
        }
        catch (Exception ex)
        {
            return null;
        }
        finally {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }


    public static bool Register(string email, string pwd, string fullname, string occup)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("RegisterUser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@email",SqlDbType.VarChar, 50).Value = email;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 10).Value = pwd;
            cmd.Parameters.Add("@fullname", SqlDbType.VarChar, 50).Value = fullname;
            cmd.Parameters.Add("@occup", SqlDbType.VarChar, 100).Value = occup;
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
        finally {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    //  returns null on sccess, error message on failure
    public static String ChangePassword(string uid, string oldpwd, string newpwd)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update users set pwd = @newpwd where uid= @uid and pwd = @oldpwd", con);
            cmd.Parameters.Add("@uid", SqlDbType.VarChar, 10).Value = uid;
            cmd.Parameters.Add("@oldpwd", SqlDbType.VarChar, 10).Value = oldpwd;
            cmd.Parameters.Add("@newpwd", SqlDbType.VarChar, 10).Value = newpwd;
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return null; // success
            else
                return "Sorry! Invalid Old Password";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    //  returns null on sccess, error message on failure
    public static String ChangeProfile( string uid, string fullname, string occupation)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update users set fullname = @fullname, occupation = @occupation where uid =@uid", con);
            cmd.Parameters.Add("@uid", SqlDbType.VarChar, 10).Value = uid;
            cmd.Parameters.Add("@fullname", SqlDbType.VarChar, 50).Value = fullname;
            cmd.Parameters.Add("@occupation", SqlDbType.VarChar, 100).Value = occupation;
            int rows = cmd.ExecuteNonQuery();
            if (rows == 1)
                return null; // success
            else
                return "Sorry! Could not change profile. Try again!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public static String ForgotPassword(string email)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(" select  pwd from  users where email = @email", con);
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = email;
            Object pwd = cmd.ExecuteScalar();
            if (pwd == null)
                return "Sorry! Invalid Email Address!";
            else
            {
          
             MailMessage m =  new MailMessage();
             m.To.Add(new MailAddress(email));
             m.From = new MailAddress("admin@classroom.com");
             m.Subject = "Password Recovery";
             m.IsBodyHtml = true;
             m.Body = "Dear User,<p>Password : " + pwd.ToString() + "<p>webmaster,<br>Forums.com";
       
             SmtpClient server = new SmtpClient("classroom");
             server.Send(m);
             return null;
            }

        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }




}
     