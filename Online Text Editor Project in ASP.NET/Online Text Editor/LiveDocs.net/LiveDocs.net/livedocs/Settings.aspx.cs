using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace LiveDocs.pages.pub
{
    //Page that displays user and admin settings based on accesslevel, user information are loaded into tables;
    public partial class Settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ContentPlaceHolder cph = (ContentPlaceHolder) Master.FindControl("MainContentPlaceHolder");
            Control userControls = cph.FindControl("userInformationPanel");
            userControls.Controls.Add(new LiteralControl("<table>"));
            userControls.Controls.Add(new LiteralControl(
                                          "<tr>" +
                                          "<td>Username</td>" +
                                          "<td colspan\"3\">Options</td>" +
                                          "</tr>"
                                          ));
            userControls.Controls.Add(new LiteralControl("<tr><td>" + HttpContext.Current.Session["username"] +
                                                         "<td><a title=\"Change nick\" href=\"#\" onclick=\"SetUserNick()\"><img src=\"/res/gfx/icons/user_edit.png\" /> </a><a title=\"Change mail\" href=\"#\" onclick=\"SetUsername()\"><img src=\"/res/gfx/icons/user_edit.png\" /> </a>" +
                                                         "<a title=\"Change password\" href=\"#\" onclick=\"SetUserPassword()\"><img src=\"/res/gfx/icons/page_white_edit.png\" /> </a>"+
                                                         "</td>" +
                                                         "</tr>"));

            //Check if user has admin privilegies
            if (SettingsVerifyAdmin())
            {
                adminControls.Controls.Add(new LiteralControl("<table>"));
                string[,] users = SettingsFetchAllUsers();
                adminControls.Controls.Add(new LiteralControl("<tr align=\"center\"><td colspan=\"6\" >Admin controls</td><tr>"));
                adminControls.Controls.Add(new LiteralControl(
                                               "<tr>" +
                                               "<td>UserID</td>" +
                                               "<td>Username</td>" +
                                               "<td>Password hash</td>" +
                                               "<td>Level</td>" +
                                               "<td>LoginToken</td>" +
                                               "<td colspan\"3\">Options</td>"+
                                               "</tr>"
                                               ));
                
                for (int r = 0; r < users.GetLength(0); r++)
                {
                    adminControls.Controls.Add(new LiteralControl("<tr>"));
                    for (int c = 0; c < users.GetLength(1); c++)
                    {
                        adminControls.Controls.Add(new LiteralControl(
                                                       "<td>" + users[r, c] + "</td>"
                                                       ));
                    }
                    adminControls.Controls.Add(new LiteralControl(
                                                         "<td><a title=\"Change username\" href=\"#\" onclick=\"SetUsername("+"\'"+users[r, 1]+"\'"+")\"><img src=\"/res/gfx/icons/user_edit.png\" /> </a>" +
                                                         "<a title=\"Change password\" href=\"#\" onclick=\"SetUserPassword(" + "\'" + users[r, 1] + "\'" + ")\"><img src=\"/res/gfx/icons/page_white_edit.png\" /> </a></td>"
                                                         ));
                    adminControls.Controls.Add(new LiteralControl("</tr>"));
                }
                adminControls.Controls.Add(new LiteralControl("</table>"));
            }
            userControls.Controls.Add(new LiteralControl("</table>"));
        }
        //Set new username
        [WebMethod]
        public static bool SettingsSetUsername(string username)
        {

            if (!LiveDocs.backend.document.UsernameVerifier.VerifyMail(username))
            {
                return false;
            }
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();
                using (MySqlTransaction mySqlTransaction = mySqlCon.BeginTransaction())
                {
                    using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                    {
                        mySqlCommand.Transaction = mySqlTransaction;
                        try
                        {
                            mySqlCommand.Parameters.AddWithValue("@userName", username);                           
                            mySqlCommand.Parameters.AddWithValue("@token", HttpContext.Current.Session["token"]);
                            mySqlCommand.CommandText = "UPDATE Users SET UserName=@userName WHERE UserName=" +
                                                       "\'" + HttpContext.Current.Session["username"] + "\'" +
                                                       " AND LoginToken=@token";
                            mySqlCommand.ExecuteNonQuery();
                            mySqlTransaction.Commit();
                        }
                        catch (Exception err)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                        finally
                        {
                            HttpContext.Current.Session["username"] = username;                         
                        }
                        return true;                                            
                    }
                }
            }
        }
        //Admin username function
        [WebMethod]
        public static bool SettingsAdminSetUsername(string newUsername,string oldUsername)
        {
            if(!LiveDocs.backend.document.UsernameVerifier.VerifyMail(newUsername))
            {
                return false;
            }
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();
                using (MySqlTransaction mySqlTransaction = mySqlCon.BeginTransaction())
                {
                    using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                    {
                        mySqlCommand.Transaction = mySqlTransaction;
                        try
                        {
                            mySqlCommand.Parameters.AddWithValue("@newUserName", newUsername);
                            mySqlCommand.Parameters.AddWithValue("@oldUserName", oldUsername);
                            mySqlCommand.Parameters.AddWithValue("@adminUserName",
                                                                 HttpContext.Current.Session["username"]);
                            mySqlCommand.Parameters.AddWithValue("@token", HttpContext.Current.Session["token"]);
                            mySqlCommand.CommandText =
                                "SELECT Level from Users WHERE Username=@adminUserName AND LoginToken=@token";
                            if(Convert.ToInt32(mySqlCommand.ExecuteScalar())==2)
                            {
                                mySqlCommand.CommandText =
                                "UPDATE Users SET UserName=@newUserName WHERE UserName=@oldUserName";
                                mySqlCommand.ExecuteNonQuery(); 
                            }
                            else
                            {
                                return false;
                            }
                           
                            mySqlTransaction.Commit();
                        }
                        catch (Exception err)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        //Set new nick
        [WebMethod]
        public static bool SettingsSetUserNick(string userNick,bool isAdmin)
        {           
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();
                using (MySqlTransaction mySqlTransaction = mySqlCon.BeginTransaction())
                {
                    using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                    {
                        mySqlCommand.Transaction = mySqlTransaction;
                        try
                        {
                            mySqlCommand.Parameters.AddWithValue("@userNick", userNick);
                            if(!isAdmin)
                            {                                
                                mySqlCommand.Parameters.AddWithValue("@token", HttpContext.Current.Session["token"]);
                                mySqlCommand.CommandText = "UPDATE Users SET UserNick=@userNick WHERE UserNick=" +
                                                           "\'" + HttpContext.Current.Session["UserNick"] + "\'" +
                                                           " AND LoginToken=@token";                               
                            }
                            else
                            {
                                mySqlCommand.CommandText =
                                "SELECT Level from Users WHERE Username=@adminUserName AND LoginToken=@token";
                                if (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 2)
                                {
                                    //FIKSE DETTE OBS OBS OBS OBS
                                    mySqlCommand.CommandText =
                                    "UPDATE Users SET UserNick=@userNick WHERE UserNick=@userNick";
                                    mySqlCommand.ExecuteNonQuery();
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            mySqlCommand.ExecuteNonQuery(); 
                            mySqlTransaction.Commit();
                        }
                        catch (Exception err)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                        finally
                        {
                            HttpContext.Current.Session["username"] = username;
                        }
                        return true;
                    }
                }
            }
            return false;
        }
        //Set new password
        [WebMethod]
        public static bool SettingsSetPassword(string password)
        {
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();
                using (MySqlTransaction mySqlTransaction = mySqlCon.BeginTransaction())
                {
                    using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                    {
                        mySqlCommand.Transaction = mySqlTransaction;
                        try
                        {
                            mySqlCommand.Parameters.AddWithValue("@password", password);
                            mySqlCommand.Parameters.AddWithValue("@username", HttpContext.Current.Session["username"]);
                            mySqlCommand.Parameters.AddWithValue("@token", HttpContext.Current.Session["token"]);
                            mySqlCommand.CommandText =
                                "UPDATE Users SET Password=Password(@password) WHERE UserName=@username AND LoginToken=@token";

                            mySqlCommand.ExecuteNonQuery();
                            mySqlTransaction.Commit();
                        }
                        catch (Exception)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        //Verify admin privilegies
        private static bool SettingsVerifyAdmin()
        {
            bool level = false;
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();
                using (MySqlTransaction mySqlTransaction = mySqlCon.BeginTransaction())
                {
                    using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                    {
                        mySqlCommand.Transaction = mySqlTransaction;
                        try
                        {
                            mySqlCommand.Parameters.AddWithValue("@username", HttpContext.Current.Session["username"]);
                            mySqlCommand.Parameters.AddWithValue("@token", HttpContext.Current.Session["token"]);
                            mySqlCommand.CommandText =
                                "SELECT Level from Users WHERE Username=@username AND Logintoken=@token";

                            level = (Convert.ToInt32(mySqlCommand.ExecuteScalar()) == 2);
                            mySqlTransaction.Commit();
                        }
                        catch (Exception e)
                        {
                            mySqlTransaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            return level;
        }

        //Fill a dataset with user values
        private static string[,] SettingsFetchAllUsers()
        {
            string[,] users;
            DataTable table = new DataTable();           
            using (MySqlConnection mySqlCon = new MySqlConnection(LiveDocs.backend.database.Database.ConnectionString))
            {
                mySqlCon.Open();

                using (MySqlCommand mySqlCommand = mySqlCon.CreateCommand())
                {
                    using (MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand))
                    {
                        mySqlCommand.CommandText = "SELECT * FROM Users";
                        mySqlDataAdapter.Fill(table);
                        users = new string[table.Rows.Count,table.Columns.Count];
                        for (int i = 0; i < table.Rows.Count; i++)
                        {
                            for (int r = 0; r < table.Columns.Count; r++)
                            {
                                users[i, r] = table.Rows[i][r].ToString();
                            }
                        }
                    }
                }
            }
            return users;
        }
    }
}