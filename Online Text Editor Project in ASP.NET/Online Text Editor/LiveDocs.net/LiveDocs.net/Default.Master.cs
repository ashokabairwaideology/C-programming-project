using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveDocs.backend;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.pages.pub
{
    public partial class MasterDefault : System.Web.UI.MasterPage
    {
        private ContentPlaceHolder mcph; //Main menubar
        private int userLevel = 0; //User accesslevel

        protected void Page_Load(object sender, EventArgs e)
        {
            mcph = MenuContentPlaceHolder;

            if (IsUserLoggedIn())
            {
                userLevel = GetUserLevel();
            }
            if (!LiveDocs.backend.Pages.CheckAccess(userLevel, MainContentPlaceHolder.Page))
            {
                MainContentPlaceHolder.Controls.Add(new Label()
                                                        {
                                                            Text =
                                                                "You do not have the neccesary accesslevel for this page. Forgot to log in?"
                                                        });
            }
        }

        private int GetUserLevel()
        {
            MySqlConnection con = new MySqlConnection(Database.ConnectionString);
            MySqlCommand command = con.CreateCommand();

            command.Parameters.Add(new MySqlParameter("@username", Session["username"]));
            command.Parameters.Add(new MySqlParameter("@token", Session["token"]));
            command.CommandText = "SELECT Level FROM Users WHERE username = @username AND logintoken = @token";
            con.Open();
            MySqlDataReader Reader = command.ExecuteReader();
            if (Reader.HasRows)
            {
                Reader.Read();
                int lvl = Reader.GetInt32("Level");
                con.Close();
                command.Dispose();
                con.Dispose();
                Reader.Dispose();
                return lvl;
            }
            return -1;
        }

        //Checks if user already is logged in on page load.
        private bool IsUserLoggedIn()
        {
            if (Session["username"] != null)
            {
                MySqlConnection con = new MySqlConnection(Database.ConnectionString);
                MySqlCommand command = con.CreateCommand();

                command.Parameters.Add(new MySqlParameter("@username", Session["username"]));
                command.Parameters.Add(new MySqlParameter("@token", Session["token"]));
                command.CommandText = "SELECT * FROM Users WHERE username = @username AND logintoken = @token";
                con.Open();
                MySqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    String username = dataReader["username"].ToString();
                    String usernick = dataReader["usernick"].ToString();
                    con.Close();
                    command.Dispose();
                    con.Dispose();
                    dataReader.Dispose();
                    LoginPlaceHolder.Controls.Clear();
                    LoginPlaceHolder.Controls.Clear();
                    //Add controls to login placeholder
                    Label welcomeLabel = new Label {Text = "Welcome, "};
                    Label usernickLabel = new Label { Text = usernick + "<br><br>" };
                    Label usernameLabel = new Label {Text = username + "<br><br>"};
                    LinkButton logoutButton = new LinkButton {Text = "Log out"};
                    logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
                    LoginPlaceHolder.Controls.Add(welcomeLabel);
                    LoginPlaceHolder.Controls.Add(usernickLabel);
                    LoginPlaceHolder.Controls.Add(usernameLabel);
                    LoginPlaceHolder.Controls.Add(logoutButton);

                    //Add all logged in menus
                    mcph.Controls.Add(new HyperLink() {Text = "Documents", NavigateUrl = "livedocs/Documents.aspx"});
                    mcph.Controls.Add(new Label() {Text = " | "});
                    mcph.Controls.Add(new HyperLink() {Text = "Settings", NavigateUrl = "livedocs/Settings.aspx"});
                    mcph.Controls.Add(new Label() {Text = " | "});
                    mcph.Controls.Add(new HyperLink() {Text = "About", NavigateUrl = "public/About.aspx"});
                    mcph.Controls.Add(new Label() {Text = " | "});
                    mcph.Controls.Add(new HyperLink() {Text = "FAQ", NavigateUrl = "public/FAQ.aspx"});
                    mcph.Controls.Add(new LiteralControl("&nbsp&nbsp&nbsp&nbsp"));
                    //Add control to display online users.
                    mcph.Controls.Add(new LiteralControl((int) Application["OnlineUsers"] + " user(s) online."));
                    return true;
                }
            }
            else
            {
                //if user not logged in add Register
                mcph.Controls.Add(new HyperLink() {Text = "Home", NavigateUrl = "Default.aspx"});
                mcph.Controls.Add(new Label() {Text = " | "});
                mcph.Controls.Add(new HyperLink() {Text = "Register", NavigateUrl = "public/Register.aspx"});
                mcph.Controls.Add(new Label() {Text = " | "});
                mcph.Controls.Add(new HyperLink() {Text = "About", NavigateUrl = "public/About.aspx"});
                mcph.Controls.Add(new Label() {Text = " | "});
                mcph.Controls.Add(new HyperLink() {Text = "FAQ", NavigateUrl = "public/FAQ.aspx"});
                mcph.Controls.Add(new LiteralControl("&nbsp&nbsp&nbsp&nbsp"));
                //Add control to display online users.
                mcph.Controls.Add(new LiteralControl((int) Application["OnlineUsers"] + " user(s) online."));
            }
            return false;
        }


        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Session["token"] = null;
            //Remove user from online counter.
            Application.Lock();
            Application["OnlineUsers"] = (int)Application["OnlineUsers"] > 0 ? ((int)Application["OnlineUsers"] - 1) : 0;
            Application.UnLock();
            Response.Redirect("~/Default.aspx");
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database.ConnectionString);
            MySqlCommand command = con.CreateCommand();
            command.Parameters.Add(new MySqlParameter("@password", PasswordTextBox.Text));
            command.Parameters.Add(new MySqlParameter("@username", UsernameTextBox.Text));
            if(LiveDocs.backend.document.UsernameVerifier.VerifyMail(UsernameTextBox.Text))
            {
                command.CommandText =
                "SELECT username,usernick FROM Users WHERE username = @username AND password = PASSWORD(@password) LIMIT 1";
            }
            else
            {
                command.CommandText =
                "SELECT username,usernick FROM Users WHERE username = @username OR usernick = @username AND password = PASSWORD(@password) LIMIT 1";
            }
                   
            con.Open();
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                Session["username"] = reader["Username"];              
                Session["usernick"] = reader["Usernick"];
                            
                String token = Util.GenerateRandomString(20);
                Session["token"] = token;
                reader.Close();

                command.Parameters.Add(new MySqlParameter("@token", token));
                command.CommandText =
                    "UPDATE users SET LoginToken = @token  WHERE username = @username OR usernick = @username";
                command.ExecuteNonQuery();
                IsUserLoggedIn();
                //Add user to login counter.
                Application.Lock();
                Application["OnlineUsers"] = (int) Application["OnlineUsers"] + 1;
                Application.UnLock();
                Response.Redirect("/livedocs/Documents.aspx");
            }
            else
            {
                MainContentPlaceHolder.Controls.Clear();
                MainContentPlaceHolder.Controls.Add(new Label() {Text = "Unable to log in"});
            }
        }
    }
}