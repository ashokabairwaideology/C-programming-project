using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.livedocs
{
    //Page that handles documentsharing, is displayed as a comprehensive popup dialog.
    public partial class DocumentSharing : System.Web.UI.Page
    {
        //Fill dialog grid before its displayed on screen.
        protected override void OnPreRender(EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@docID", HttpContext.Current.Request["docID"]));
                    command.CommandText =
                        "SELECT username, users.userID, documentaccess.AccessLevel as level FROM documentaccess, users WHERE documentaccess.docID = @docID AND documentaccess.userID = users.userID ";
                    MySqlDataReader reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        string levelString = "";
                        switch (reader.GetInt32("level"))
                        {
                            case 1:
                                levelString = "Read";
                                break;
                            case 2:
                                levelString = "Read/Write";
                                break;
                        }
                        if(!reader["username"].Equals(Session["username"])) //Not owner
                            UserList.Controls.Add(new LiteralControl("<tr>" +
                                                      "<td>"+reader["username"]+"</td>" +
                                                      "<td>"+levelString+"</td>" +
                                                      "<td><a href=\"#\" onclick=\"PageMethods.RevokeSharingAccess(" +
                                                        HttpContext.Current.Request["docID"].ToString() +
                                                        ", " + reader["userID"] +
                                                        ", DocumentListEditPermissions(" + HttpContext.Current.Request["docID"].ToString() + "))\"title=\"Revoke rights\"><img src=\"/res/gfx/icons/page_white_delete.png\"></a></td>" +
                                                      "</tr>"));  
                        else
                            UserList.Controls.Add(new LiteralControl("<tr>" +
                                                      "<td>" + reader["username"] + "</td>" +
                                                      "<td> Owner </td>" +
                                                      "<td></td>" +
                                                      "</tr>"));  
                    }
                }
            }        
        }
    }
}