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
    //Page that handles document export as a rich text file via menu with option to change file extension.
    public partial class ExportDocument : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            //Return file to user
            String content = "";
            int id;
            Int32.TryParse(Request["revID"], out id);
            content = FetchRevisionContent(id);
            DocumentPlaceHolder.Controls.Add(new LiteralControl(content));
            Response.AddHeader("content-disposition", @"attachment;filename="+Request["docName"].ToString());
        }
        //Fetch document content by specifying revision id.
        private string FetchRevisionContent(int revID)
        {
            string content = "";
            string token = (String) HttpContext.Current.Session["token"];
            string user = (String) HttpContext.Current.Session["username"];
            if (token != null && user != null)
            {
                MySqlConnection sqlCon = new MySqlConnection(Database.ConnectionString);
                MySqlCommand sqlCommand = sqlCon.CreateCommand();
              
                    sqlCon.Open();
                    sqlCommand.Parameters.AddWithValue("@token", token);
                    sqlCommand.Parameters.AddWithValue("@username", user);
                    sqlCommand.Parameters.AddWithValue("@revisionID", revID);
                    sqlCommand.CommandText =
                        "SELECT Revisions.Content FROM Revisions,DocumentAccess,Users WHERE Revisions.RevisionID=@revisionID AND Revisions.DocID=DocumentAccess.DocID AND DocumentAccess.UserID=Users.UserID AND Users.Username=@username AND Users.LoginToken=@token";
                    content = sqlCommand.ExecuteScalar().ToString();
                    return LiveDocs.livedocs.Editor.ParseMarkup(content);
                
            }
                return "You do not have sufficient access for this document!";                     
        }
    }
}