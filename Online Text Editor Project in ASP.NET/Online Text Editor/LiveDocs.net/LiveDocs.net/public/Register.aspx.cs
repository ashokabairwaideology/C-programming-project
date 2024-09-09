using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.pages.pub
{
    //Page that handles the registration form for new users.
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RegistrationSubmit_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder cph = (ContentPlaceHolder) Master.FindControl("MainContentPlaceHolder");

            if (!LiveDocs.backend.document.UsernameVerifier.VerifyMail(RegisterUsername.Text))
            {
                cph.Controls.Add(new Literal() {Text = "<b>Username must be a valid(!) email adress.</b>"});
                return;
            }
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    try
                    {
                        command.Parameters.Add(new MySqlParameter("@username", RegisterUsername.Text));
                        command.Parameters.Add(new MySqlParameter("@password", RegisterPassword.Text));
                        command.Parameters.Add(new MySqlParameter("@usernick", RegisterUserNick.Text));
                        command.CommandText = "SELECT username,usernick FROM Users WHERE username=@username";
                        
                        MySqlDataReader reader = command.ExecuteReader();//)
                            if(reader.HasRows)
                            {
                                reader.Read();
                                if (reader[0] != null)
                                {
                                    cph.Controls.Add(new Literal
                                                         {Text = "Mail already registered, please choose a different mail."});
                                }
                                else if (reader[1] != null)
                                {
                                    cph.Controls.Add(new Literal
                                                         {
                                                             Text =
                                                                 "Username already registered, please choose a different username."
                                                         });
                                }
                                reader.Close();
                            }
                            else
                            {
                                reader.Close();
                                command.CommandText =
                                    "INSERT INTO Users VALUES (null,@username,Password(@password),1,null,@usernick);";
                                command.ExecuteNonQuery();
                                cph.Controls.Clear();
                                cph.Controls.Add(new Literal() {Text = "<h1>Registration complete!</h1>"});
                                cph.Controls.Add(new Label()
                                                     {
                                                         Text =
                                                             "Welcome to LiveDocs. You may now log in. Your first document has already been created!"
                                                     });
                            }
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }
                }
            }
        }
    }
}