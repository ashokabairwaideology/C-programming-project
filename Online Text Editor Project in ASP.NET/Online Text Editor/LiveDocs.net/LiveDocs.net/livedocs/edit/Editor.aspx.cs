using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using LiveDocs.backend.database;

namespace LiveDocs.livedocs
{
    //Markdown editor class
    public partial class Editor : System.Web.UI.Page
    {
        private static string content;
        private static int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            TextSizeDropDownList.Items.AddRange(getFontSizeList());
            FontDropDownList.Items.AddRange(getFontsList());
            FontDropDownList.Attributes.Add("onchange", "return buttonClick(this.value);");
            TextSizeDropDownList.Attributes.Add("onchange", "return buttonClick(this.value);");
            TextSizeDropDownList.SelectedIndex = 4;

            if (Request["revID"] != null) //RevID present
            {
                Int32.TryParse(Request["revID"], out id);
                Session["revID"] = id;
                content = FetchRevision(id);
            }
            else if (Request["id"] != null) //ID present(Assume docID)
            {
                Int32.TryParse(Request["id"], out id);
                Session["docID"] = id;
                Response.Redirect(rebuildDocIDQuerystring());
            }
            else if (Request["docID"] != null) //docID present
            {
                Int32.TryParse(Request["docID"], out id);
                Session["docID"] = id;
                Response.Redirect(rebuildDocIDQuerystring());
            }


            PopulateRevisionTree();
            if (!IsPostBack)
            {
                SendChatMessage("has joined the revision", ChatType.EVENT);
            }
            UpdateChat();
        }


        private string rebuildDocIDQuerystring() //Returns new url with appended revisionID on docID request
        {
            UriBuilder u = new UriBuilder(Request.Url);
            NameValueCollection nv = new NameValueCollection(Request.QueryString);

            /* A NameValueColllection automatically makes room if this is a new
               name. You don't have to check for NULL.
             */
            nv["revID"] = CurrentDocumentInfo()[2];

            /* Appending to u.Query doesn't quite work, it
               overloaded to add an extra '?' each time. Have to 
               use StringBuilder instead.
            */
            StringBuilder newQuery = new StringBuilder();
            newQuery.Append(u.ToString());
            newQuery.Append("&revID=" + nv["revID"]);

            return newQuery.ToString();
        }

        private void PopulateRevisionTree()
        {
            InnerWrapperRevisions.Controls.Add(new LiteralControl("<b>Revision list</b><br><br>"));

            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.AddWithValue("@docID", HttpContext.Current.Session["docID"]);
                    command.CommandText =
                        "SELECT RevisionID, Name, ParentRevisionID, comments FROM revisions WHERE docID = @docID ORDER BY RevisionID DESC";
                    MySqlDataReader reader = command.ExecuteReader();

                    InnerWrapperRevisions.Controls.Add(
                        new LiteralControl("<table> " +
                                           "<tr> " +
                                           "<td><b>ID</b></td>" +
                                           "<td><b>Name</b></td>" +
                                           "<td><b>Message</b></td>" +
                                           "<td><b>Based on</b></td>" +
                                           "</tr>"));
                    while (reader.Read())
                    {
                        InnerWrapperRevisions.Controls.Add(
                            new LiteralControl("<tr> " +
                                               "<td><a href=\"?revID=" + reader["RevisionID"] + "\">" +
                                               reader["RevisionID"] + "</a></td>" +
                                               "<td><a href=\"?revID=" + reader["RevisionID"] + "\">" + reader["Name"] +
                                               "</a></td>" +
                                               "<td>" + reader["comments"] + "</td>" +
                                               "<td>" + reader["ParentRevisionID"] + "</td>" +
                                               "</tr>"));
                    }
                    InnerWrapperRevisions.Controls.Add(
                        new LiteralControl("</table>"));
                }
            }
        }


        private ListItem[] getFontsList() //Browser safe fonts 
        {
            ListItem[] fonts = new ListItem[3];
            fonts[0] = (new ListItem("Arial"));
            fonts[1] = (new ListItem("Comic Sans MS"));
            fonts[2] = (new ListItem("Courier"));

            return fonts;
        }

        private ListItem[] getFontSizeList() //Browser safe fonts 
        {
            ListItem[] size = new ListItem[10];
            size[0] = (new ListItem("1"));
            size[1] = (new ListItem("2"));
            size[2] = (new ListItem("3"));
            size[3] = (new ListItem("4"));
            size[4] = (new ListItem("5"));
            size[5] = (new ListItem("6"));
            size[6] = (new ListItem("7"));
            size[7] = (new ListItem("8"));
            size[8] = (new ListItem("9"));
            size[9] = (new ListItem("10"));
            return size;
        }

        private static string FetchRevision(int id) //Fetch revision content from DB
        {
            string content = "Empty";

            if (id <= 0)
            {
                return content;
            }

            string token = (String) HttpContext.Current.Session["token"];
            string user = (String) HttpContext.Current.Session["username"];
            if (token != null && user != null)
            {
                MySqlConnection sqlCon = new MySqlConnection(Database.ConnectionString);
                MySqlCommand sqlCommand = sqlCon.CreateCommand();
                try
                {
                    sqlCon.Open();
                    sqlCommand.Parameters.AddWithValue("@token", token);
                    sqlCommand.Parameters.AddWithValue("@username", user);
                    sqlCommand.Parameters.AddWithValue("@revisionID", id);

                    sqlCommand.CommandText =
                        "SELECT Revisions.Content FROM Revisions,DocumentAccess,Users WHERE Revisions.RevisionID=@revisionID AND Revisions.DocID=DocumentAccess.DocID AND DocumentAccess.UserID=Users.UserID AND Users.Username=@username AND Users.LoginToken=@token";
                    content = sqlCommand.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    return "Error fetching document";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCommand.Dispose();
                    sqlCon.Dispose();
                }
            }
            return content;
        }

        public static string FetchLatestDocument(int id) //Fetch latest revision by document id parameter from DB
        {
            string content = "Empty";

            if (id <= 0)
            {
                return content;
            }

            string token = (String) HttpContext.Current.Session["token"];
            string user = (String) HttpContext.Current.Session["username"];
            if (token != null && user != null)
            {
                MySqlConnection sqlCon = new MySqlConnection(Database.ConnectionString);
                MySqlCommand sqlCommand = sqlCon.CreateCommand();
                try
                {
                    sqlCon.Open();
                    sqlCommand.Parameters.AddWithValue("@token", token);
                    sqlCommand.Parameters.AddWithValue("@username", user);
                    sqlCommand.Parameters.AddWithValue("@docId", id);

                    sqlCommand.CommandText =
                        "SELECT Revisions.Content FROM Revisions,Documents,Users,DocumentAccess WHERE Documents.HeadRevisionID=Revisions.RevisionID " +
                        "AND DocumentAccess.DocID=@docId AND Documents.DocID=DocumentAccess.DocID AND DocumentAccess.UserID=Users.UserID AND Users.UserName=@username AND Users.LoginToken=@token";
                    content = sqlCommand.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    return "Error fetching document";
                }
                finally
                {
                    sqlCon.Close();
                    sqlCommand.Dispose();
                    sqlCon.Dispose();
                }
            }
            return content;
        }

        [WebMethod]
        [ScriptMethod]
        public static string UpdateRevision(string markupContent, bool updatePriority) //Writes changed text to database
        {
            string revContent = markupContent;

            if (id != null && id > 0 && revContent != "")
            {
                int revision = (int) HttpContext.Current.Session["revID"];
                string token = (String) HttpContext.Current.Session["token"];
                string user = (String) HttpContext.Current.Session["username"];
                using (MySqlConnection sqlCon = new MySqlConnection(Database.ConnectionString))
                {
                    sqlCon.Open();
                    using (MySqlCommand sqlCommand = sqlCon.CreateCommand())
                    {
                        sqlCommand.Parameters.AddWithValue("@content", markupContent);
                        sqlCommand.Parameters.AddWithValue("@token", token);
                        sqlCommand.Parameters.AddWithValue("@user", user);
                        sqlCommand.Parameters.AddWithValue("@revisionID", revision);
                        if (updatePriority)
                        {
                            sqlCommand.CommandText =
                                "UPDATE Revisions,DocumentAccess,Users SET Revisions.Content=@content WHERE Revisions.RevisionID=@revisionID AND Revisions.DocID=DocumentAccess.DocID AND DocumentAccess.UserID=Users.UserID AND DocumentAccess.AccessLevel=2 AND Users.UserName=@user AND Users.LoginToken=@token";
                            sqlCommand.ExecuteNonQuery();
                        }
                        else
                        {
                            sqlCommand.CommandText =
                                "SELECT Revisions.Content FROM Revisions,DocumentAccess,Users WHERE Revisions.RevisionID=@revisionID AND Revisions.DocID=DocumentAccess.DocID AND DocumentAccess.UserID=Users.UserID AND Users.Username=@user AND Users.LoginToken=@token";
                            revContent = (String) sqlCommand.ExecuteScalar();
                        }

                    }
                    return revContent;
                }
            }
            return "";
        }

        [WebMethod]
        [ScriptMethod]
        public static string ParseMarkup(string textInput) //Converts markdown text to xhtml equivalent
        {
            ParsingDictionary pd = new ParsingDictionary(); //Dictionary for markup parsing
            string text = textInput;
            foreach (Tag t in pd)
            {
                int start = text.IndexOf(t.mTag);
                while (start != -1)
                {
                    string pre = text.Substring(0, start);
                    string inb = t.hTag;
                    string post = text.Substring(start + t.mTag.Length);
                    text = pre + inb + post;
                    start = text.IndexOf(t.mTag);
                }
            }

            return text;
        }

        [WebMethod]
        public static String[] CurrentDocumentInfo()//Fetches document info from database
        {
            //0 - DocID
            //1 - RevisionID
            //2 - Highest revisionID
            String highestRev;
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                con.Open();

                using (MySqlCommand command = con.CreateCommand())
                {
                    command.Parameters.AddWithValue("@docID", HttpContext.Current.Session["docID"]);
                    command.CommandText =
                        "SELECT COUNT(revisionID) FROM revisions WHERE docID = @docID";

                    highestRev = command.ExecuteScalar().ToString();
                }
                string docID = HttpContext.Current.Session["docID"] != null
                                   ? HttpContext.Current.Session["docID"].ToString()
                                   : "";
                string revID = HttpContext.Current.Session["revID"] != null
                    ? HttpContext.Current.Session["revID"].ToString()
                                   : "";
                String[] docInfo = {
                                       docID,
                                       revID,
                                       highestRev
                                   };
                return docInfo;
            }
        }

        [WebMethod]
        public static int CommitRevision(int revID, string name, string message, bool isBasedOnOldCommit) //Send revision to database.
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                int docID;
                con.Open();
                int returnRevision = 0;

                using (MySqlTransaction mst = con.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        try
                        {
                            command.Transaction = mst;
                            command.Parameters.Add(new MySqlParameter("@revID", revID));
                            command.Parameters.Add(new MySqlParameter("@username",
                                                                      HttpContext.Current.Session["username"]));
                            command.Parameters.Add(new MySqlParameter("@token",
                                                                      HttpContext.Current.Session["token"].ToString()));
                            command.Parameters.Add(new MySqlParameter("@name", name));
                            command.Parameters.Add(new MySqlParameter("@message", message));
                            command.CommandText = "SELECT docID FROM revisions where RevisionID = @revID ";
                            docID = (int) command.ExecuteScalar();
                            command.Parameters.Add(new MySqlParameter("@docID", docID));
                            if (!isBasedOnOldCommit)
                                //This means the commit is not based on an old revision. Proceed as usual
                            {
                                command.CommandText =
                                    "UPDATE Revisions,documents,documentaccess SET revisions.Name = @name, revisions.comments = @message, revisions.date = NOW() WHERE revisions.RevisionID = @revID AND revisions.docID = documents.docID AND documents.docID = documentaccess.docID and documentaccess.userID = (SELECT userID from users where username = @username AND logintoken = @token LIMIT 1); ";
                                command.ExecuteNonQuery();

                            }
                            command.CommandText =
                                "SELECT content FROM Revisions WHERE RevisionID = @revID ";
                            String revisionContent = command.ExecuteScalar().ToString();

                            command.Parameters.Add(new MySqlParameter("@content", revisionContent));
                            if (!isBasedOnOldCommit) //Normal operation
                                command.CommandText =
                                    "INSERT INTO Revisions VALUES(null, @docID, \"HEAD\", NOW(), @revID, @content,\"\")";
                            else //Occurs when commit is branched off old commit
                            {
                                command.CommandText =
                                    "INSERT INTO Revisions VALUES(null, @docID, @name, NOW(), @revID, @content,@message)";
                            }
                            command.ExecuteNonQuery();
                            command.CommandText =
                                "UPDATE Documents set HeadRevisionID=(SELECT Max(revisionID) FROM Revisions WHERE docID=@docID) WHERE docID=@docID";
                            command.ExecuteNonQuery();
                            command.CommandText = "SELECT Max(RevisionID) FROM Revisions WHERE docID=@docID ";
                            returnRevision = (int) command.ExecuteScalar();
                            mst.Commit();
                            SendChatMessage("has commited a new revision: <a href=\"?revID="+returnRevision+"\">"+name+"</a>", ChatType.EVENT);
                        }
                        catch (Exception e)
                        {
                            mst.Rollback();
                            //throw new Exception("Commit error : " + e.Message);
                        }
                        return returnRevision;
                    }

                }
            }
        }

        [ScriptMethod]
        [WebMethod]
        public static string FetchPageContent()
        {
            if (content == null)
            {
                return "";
            }
            return content;
        }

        [WebMethod]
        public static bool CheckPageQuery() //Checks if doc/revision querystring is present on page request
        {
            if (HttpContext.Current.Session["id"] != null || HttpContext.Current.Session["revID"] != null ||
                HttpContext.Current.Session["docID"] != null)
            {
                return true;
            }
            return false;
        }

        protected void ChatSend_Click(object sender, EventArgs e) //Chat click handler
        {
            SendChatMessage(ChatText.Text, ChatType.MESSAGE);
            
            UpdateChat();
            ChatText.Text = String.Empty;
        }

        private enum ChatType
        {
            MESSAGE,EVENT
        }

        private static void SendChatMessage(string message, ChatType type) //Chat message handler
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                string chatContent = "";
                con.Open();
                using (MySqlTransaction mst = con.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        try
                        {
                            command.Transaction = mst;
                            command.Parameters.Add(new MySqlParameter("@revID", HttpContext.Current.Session["revID"]));
                            command.CommandText = "SELECT content from chat WHERE revID = @revID LIMIT 1";
                            chatContent = (string) command.ExecuteScalar();
                        }
                        catch (Exception e)
                        {
                            content = e.Message;
                        }

                    }
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        var start = DateTime.Now;
                        string name = HttpContext.Current.Session["usernick"].ToString();
                        string formattedMessage = "";
                        if(type==ChatType.MESSAGE)
                            formattedMessage = "<span style=\" color: #999999;\"> [" + start.ToShortTimeString() + "]</span> <b>" + HttpContext.Current.Session["usernick"] + "</b> - " +
                                          message + "<br>";
                        else if(type==ChatType.EVENT)
                            formattedMessage = "<span style=\" color: #999999;\"> [" + start.ToShortTimeString() + "]</span> <b>" + HttpContext.Current.Session["usernick"] + "</b> - <span style=\" color: #555555;\">" +
                                         message + "</span><br>";
                        command.Transaction = mst;
                        command.Parameters.Add(new MySqlParameter("@revID", HttpContext.Current.Session["revID"]));
                        command.Parameters.Add(new MySqlParameter("@content", chatContent + formattedMessage));
                        command.CommandText = "UPDATE chat SET content = @content  WHERE revID = @revID LIMIT 1";
                        command.ExecuteNonQuery();
                        mst.Commit();
                    }
                }
            }
        }

        [WebMethod]
        public static string FetchChatContent() //Get text from chat window
        {
            using (MySqlConnection con = new MySqlConnection(Database.ConnectionString))
            {
                string chatContent = "";
                con.Open();
                using (MySqlTransaction mst = con.BeginTransaction(IsolationLevel.Serializable))
                {
                    using (MySqlCommand command = con.CreateCommand())
                    {
                        try
                        {
                            command.Transaction = mst;
                            command.Parameters.Add(new MySqlParameter("@revID", HttpContext.Current.Session["revID"]));
                            command.CommandText = "SELECT content from chat WHERE revID = @revID LIMIT 1";
                            chatContent = (string) command.ExecuteScalar();
                        }
                        catch (Exception e)
                        {
                            content = e.Message;
                        }
                    }
                }
                return chatContent;
            }
        }

        private void UpdateChat()
        {
            string chatContent = FetchChatContent();
            ChatLog.Controls.Clear();
            ChatLog.Controls.Add(new LiteralControl(chatContent));

        }

        public class ParsingDictionary : List<Tag> //Used for custom tags and textarea specific tags
        {
            public ParsingDictionary()
            {
                Add(new Tag("<1>", @"<span style=""font-size: 5px"">"));
                Add(new Tag("</1>", "</span>"));
                Add(new Tag("<2>", @"<span style=""font-size: 8px"">"));
                Add(new Tag("</2>", "</span>"));
                Add(new Tag("<3>", @"<span style=""font-size: 10px"">"));
                Add(new Tag("</3>", "</span>"));
                Add(new Tag("<4>", @"<span style=""font-size: 12px"">"));
                Add(new Tag("</4>", "</span>"));
                Add(new Tag("<5>", @"<span style=""font-size: 15px"">"));
                Add(new Tag("</5>", "</span>"));
                Add(new Tag("<6>", @"<span style=""font-size: 18px"">"));
                Add(new Tag("</6>", "</span>"));
                Add(new Tag("<7>", @"<span style=""font-size: 25px"">"));
                Add(new Tag("</7>", "</span>"));
                Add(new Tag("<8>", @"<span style=""font-size: 35px"">"));
                Add(new Tag("</8>", "</span>"));
                Add(new Tag("<9>", @"<span style=""font-size: 50px"">"));
                Add(new Tag("</9>", "</span>"));
                Add(new Tag("<10>", @"<span style=""font-size: 75px"">"));
                Add(new Tag("</10>", "</span>"));
                Add(new Tag("<arial>", @"<span style=""font-family: Arial,Helvetica,sans-serif"">"));
                //Specify font family first and generic family as a fallback if lack of broser support
                Add(new Tag("</arial>", "</span>"));
                Add(new Tag("<comic>", @"<span style=""font-family: 'Comic Sans MS',cursive"">"));
                Add(new Tag("</comic>", "</span>"));
                Add(new Tag("<courier>", @"<span style=""font-family: Courier,monospace"">"));
                Add(new Tag("</courier>", "</span>"));
                Add(new Tag("script", "*code*")); //Simple script prevention
                Add(new Tag("\n", "<br>"));
            }
        }

        public struct Tag
        {
            public string mTag;
            public string hTag;

            public Tag(string markupTag, string htmlTag) //Markup tag and html counterpart
            {
                mTag = markupTag;
                hTag = htmlTag;
            }
        }
    }
}
