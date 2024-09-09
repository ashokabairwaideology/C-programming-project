using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiveDocs.net.Test
{
    public partial class Content : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }


        [WebMethod]
        public static void UpdateServer(String content)
        {
            // create a writer and open the file
            TextWriter tw = new StreamWriter("doc.txt");

            // write a line of text to the file
            tw.Write(content+"Hello");

            tw.Close();
        }

        [WebMethod]
        public static String UpdateClient()
        {
            StreamReader tr = new StreamReader("doc.txt");
            String content = tr.ReadToEnd();
            tr.Close();

            return content;
        }
      
    }
}