using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.pages.pub
{
    //Page that handles public viewing of document for guest users
	public partial class ViewPublicDocument : System.Web.UI.Page
	{
	    public static int requestID;
		protected void Page_PreInit(object sender, EventArgs e)
		{
		    Int32.TryParse(Request["id"], out requestID);
		}
        [WebMethod]
        public static bool IsFullPublic()
        {

            bool isPublic = false;
            bool isFullyPublic = false;

            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.AddWithValue("@docID", requestID);
                    command.CommandText =
                        "SELECT public,publicPassword FROM documents WHERE docID = @docID";
                    MySqlDataReader r = command.ExecuteReader();
                    while(r.Read())
                    {
                        isPublic = Convert.ToBoolean(r["public"]);
                        if(isPublic && (r["publicPassword"].ToString() == "" || r["publicPassword"].ToString() == "public"))
                        {
                            isFullyPublic = true;
                        }
                    }
                    

                }

            }
            return isFullyPublic;
        }

        [WebMethod]
        public static string FetchPublicContent(string password)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.AddWithValue("@docID", requestID);
                    command.Parameters.AddWithValue("@password", password);
                    command.CommandText =
                       "SELECT Revisions.Content from Revisions join Documents on Revisions.docID=Documents.docID where Revisions.docID=@docID and Revisions.revisionID=(Select Max(revisionID) from Revisions where docID=@docID) AND publicPassword = @password" ;
                    MySqlDataReader reader = command.ExecuteReader();

                    if(reader.HasRows)
                    {
                        reader.Read();
                        return LiveDocs.livedocs.Editor.ParseMarkup((String)reader[0]);
                    }
                    else
                    {
                        throw new Exception("Password not correct or document does not exist");
                    }

                }

            }
            return null;
            

        }
	}
}