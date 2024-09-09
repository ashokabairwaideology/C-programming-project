using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LiveDocs.backend.database;
using MySql.Data.MySqlClient;

namespace LiveDocs.pages.livedocs
{
    //Page that handles document listing and controls
    public partial class Documents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Reference static elements and add html layout
            ContentPlaceHolder cph = (ContentPlaceHolder) Master.FindControl("MainContentPlaceHolder");
            Control docListDiv = cph.FindControl("DocumentListControl");
            docListDiv.Controls.Add(new LiteralControl(
                                        "<table>" +
                                        "<tr>" +
                                        "<td>Title</td>" +
                                        "<td>Last edited</td>" +
                                        "<td colspan\"3\">Options</td>" +
                                        "</tr>"
                                        ));
            //Retrive document, permissions and fill table with returned data from db
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                using (MySqlCommand command = con.CreateCommand())
                {
                    con.Open();
                    command.Parameters.Add(new MySqlParameter("@username", Session["username"]));
                    command.Parameters.Add(new MySqlParameter("@token", Session["token"].ToString()));
                    command.CommandText =
                        "SELECT users.userID as userID, documents.ownerID as ownerID, documents.docID,documents.title as title ,MAX(revisions.date) as date FROM Documents,revisions,users,documentaccess WHERE (documents.docID = documentaccess.docID AND documentaccess.userID = users.UserID AND users.UserName = @username AND users.logintoken = @token) GROUP BY documents.docID ORDER BY revisions.date DESC ";
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string collabOptions = "<td><a href=\"#\" onclick=\"DocumentListGetDocInfo(" +
                                               reader["docID"].ToString() +
                                               ", DocumentListRevokeMyPermissions)\"title=\"Revoke my permissions for this document\"><img src=\"/res/gfx/icons/page_white_delete.png\"></a></td><td></td><td></td>";

                        string ownerOptions = "<td><a href=\"#\" onclick=\"DocumentListEditPermissions(" +
                                              reader["docID"].ToString() +
                                              ")\" title=\"Add/Remove users read/write permissions\" ><img src=\"/res/gfx/icons/user_edit.png\"></a></td>" +
                                              "<td><a href=\"#\" title=\"Rename document\" onclick=\"DocumentRename(" +
                                              reader["docID"] +
                                              ")\"</a><img src=\"/res/gfx/icons/page_white_edit.png\"></td>" +
                                              "<td><a href=\"#\" onclick=\"DocumentListGetDocInfo(" +
                                              reader["docID"].ToString() +
                                              ", DocumentListPublishSettings)\" title=\"Publishing settings\"><img src=\"/res/gfx/icons/page_white_world.png\"></a></td>" +
                                              "<td><a href=\"#\" onclick=\"DocumentListGetDocInfo(" +
                                              reader["docID"].ToString() +
                                              ", DocumentListDelete)\"title=\"Delete the document\"><img src=\"/res/gfx/icons/page_white_delete.png\"></a></td>";
                        String options = reader["userID"].ToString() == reader["ownerID"].ToString()
                                             ? ownerOptions
                                             : collabOptions;
                        docListDiv.Controls.Add(new LiteralControl(
                                                    "<tr>" +
                                                    "<td><a href=\"/livedocs/edit/Editor.aspx?id=" +
                                                    reader["docID"].ToString() + "\" title=\"Edit document\"><b>" +
                                                    reader["title"].ToString() + "</b></a></td>" +
                                                    "<td>" + reader["date"].ToString() + "</td>" +
                                                    options +
                                                    "</tr>"
                                                    ));
                    }
                }
            }

            docListDiv.Controls.Add(new LiteralControl("</table>"));
        }

        //Fetch document info from db
        [WebMethod]
        public static String[] GetDocumentInfo(int docID)
        {
            List<String> docinfo = new List<string>();
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@username", HttpContext.Current.Session["username"]));
                    command.Parameters.Add(new MySqlParameter("@token", HttpContext.Current.Session["token"].ToString()));
                    command.Parameters.Add(new MySqlParameter("@docID", docID));
                    command.CommandText =
                        "SELECT documents.docID as docID ,documents.title as title, documents.public, revisions.DATE as date FROM Documents, users, documentaccess, revisions WHERE (documents.docID = @docID AND documents.docID = documentaccess.docID AND documentaccess.userID = users.UserID AND users.UserName = @username AND users.logintoken = @token) GROUP BY documents.docID ORDER BY revisions.DATE DESC ";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        docinfo.Add(reader["docID"].ToString());
                        docinfo.Add(reader["title"].ToString());
                        if (reader.GetBoolean("Public"))
                        {
                            docinfo.Add(1.ToString());
                            docinfo.Add("/public/ViewPublicDocument.aspx?id=" + reader["docID"]);
                        }
                        else
                        {
                            docinfo.Add(0.ToString());
                            docinfo.Add("");
                        }
                    }
                    else
                    {
                        docinfo = null;
                    }
                }
                return docinfo.ToArray();
            }
        }

        //Change document publish settings
        [WebMethod]
        public static int PublishDocument(int docID, string pwd, bool makePublic)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@public", makePublic));
                    command.Parameters.Add(new MySqlParameter("@username", HttpContext.Current.Session["username"]));
                    command.Parameters.Add(new MySqlParameter("@token", HttpContext.Current.Session["token"].ToString()));
                    command.Parameters.Add(new MySqlParameter("@docID", docID));
                    command.Parameters.Add(new MySqlParameter("@publicPassword", pwd));
                    command.CommandText =
                        "UPDATE documents,users,documentaccess SET documents.Public = @public, documents.publicPassword=@publicPassword WHERE (documents.docID = documentaccess.docID AND documentaccess.userID = users.UserID AND users.UserName = @username AND users.logintoken = @token AND documents.docID = @docID)";
                    command.ExecuteNonQuery();
                }
            }
            return docID;
        }

        //Deletes document
        [WebMethod]
        public static void DeleteDocument(int docID)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@username", HttpContext.Current.Session["username"]));
                    command.Parameters.Add(new MySqlParameter("@token", HttpContext.Current.Session["token"].ToString()));
                    command.Parameters.Add(new MySqlParameter("@docID", docID));
                    command.CommandText =
                        "DELETE FROM documents WHERE ownerID = (SELECT userID from users where username = @username AND logintoken = @token LIMIT 1) AND docID = @docID";
                    command.ExecuteNonQuery();
                }
            }
        }

        //Remove edit permissions from user.
        [WebMethod]
        public static void RevokePermissions(int docID)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@username", HttpContext.Current.Session["username"]));
                    command.Parameters.Add(new MySqlParameter("@token", HttpContext.Current.Session["token"].ToString()));
                    command.Parameters.Add(new MySqlParameter("@docID", docID));
                    command.CommandText =
                        "DELETE FROM documentaccess WHERE userID = (SELECT userID from users where username = @username AND logintoken = @token LIMIT 1) AND docID = @docID";
                    command.ExecuteNonQuery();
                }
            }
        }

        //Create a new document and setup revisions and documentaccess defaults.
        [WebMethod]
        public static int CreateDocument(string title)
        {
            int docID = 0;
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlTransaction mst = con.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        try
                        {
                            command.Transaction = mst;
                            command.Parameters.Add(new MySqlParameter("@username",
                                                                      HttpContext.Current.Session["username"]));
                            command.Parameters.Add(new MySqlParameter("@token",
                                                                      HttpContext.Current.Session["token"].ToString()));
                            command.Parameters.Add(new MySqlParameter("@title", title));
                            command.CommandText =
                                "INSERT INTO documents VALUES (null,@title,(SELECT userID from users where username = @username AND logintoken = @token),null,false, \"\")";

                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT docID from documents ORDER BY docID DESC LIMIT 1";
                            //Select latest
                            docID = (int) command.ExecuteScalar();
                            command.Parameters.Add(new MySqlParameter("@docID", docID));
                            command.CommandText =
                                "INSERT INTO revisions VALUES (null, @docID,\"HEAD\",NOW(),null,\"DOCUMENT TEXT\",\"\"); " +
                                "INSERT INTO DocumentAccess VALUES((SELECT userID from Users WHERE users.UserName = @username AND users.logintoken = @token),@docID,2);";
                            command.ExecuteNonQuery();
                            mst.Commit();
                        }
                        catch (Exception e)
                        {
                            mst.Rollback();
                            throw new Exception("Error creating document: " + e.Message);
                        }
                    }
                }
            }
            return docID;
        }

        //Share document with another user, send mail notice to affected user.
        [WebMethod]
        public static int SharingAddUser(string username, int docID, int level)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
                {
                    con.Open();
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        command.Parameters.Add(new MySqlParameter("@username", username));
                        command.Parameters.Add(new MySqlParameter("@docID", docID));
                        command.Parameters.Add(new MySqlParameter("@level", level));
                        command.CommandText =
                            "INSERT INTO documentaccess VALUES ((SELECT userID from users where username = @username),@docID,@level)";
                        command.ExecuteNonQuery();
                    }
                    string docTitle;
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        command.Parameters.Add(new MySqlParameter("@docID", docID));
                        command.CommandText =
                            "SELECT title from documents where docID = @docID";
                        docTitle = command.ExecuteScalar().ToString();
                    }

                    System.Net.Mail.MailMessage msg = new MailMessage {From = new MailAddress("admin@livedocs.net")};
                    msg.To.Add(new MailAddress(username));
                    msg.Subject = "LiveDocs.net document sharing notification";
                    msg.Body = "Hello!\n\n" +
                               "" +
                               "Someone has shared the document " + docTitle + " with you at LiveDocs!\n" +
                               "Log on now to check it out!";
                    System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.online.no");
                    smtp.Send(msg);
                }
            }
            catch (Exception e)
            {
                return -1;
            }
            return docID;
        }

        //Remove document sharing for a specific user.
        [WebMethod]
        public static void RevokeSharingAccess(int docID, int userID)
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();
                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.Add(new MySqlParameter("@docID", docID));
                    command.Parameters.Add(new MySqlParameter("@userID", userID));
                    command.CommandText =
                        "DELETE FROM documentaccess where docID = @docID AND userID = @userID";
                    command.ExecuteNonQuery();
                }
            }
        }

        //Rename document
        [WebMethod]
        public static void RenameDocument(string docName, int docID)
        {
            using (MySqlConnection sqlCon = new MySqlConnection(Database.ConnectionString))
            {
                sqlCon.Open();
                using (MySqlCommand sqlCommand = sqlCon.CreateCommand())
                {
                    sqlCommand.Parameters.AddWithValue("@docName", docName);
                    sqlCommand.Parameters.AddWithValue("@docID", docID);
                    sqlCommand.CommandText = "UPDATE Documents SET Title=@docName WHERE docID=@docID";
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}