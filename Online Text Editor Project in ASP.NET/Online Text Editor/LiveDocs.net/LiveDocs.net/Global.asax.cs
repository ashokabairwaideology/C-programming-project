using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LiveDocs
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Initialize user counter.
            Application["OnlineUsers"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            
            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            //Runs when session ends, user closes browser or session timeout.
            Application.Lock();

            Application["OnlineUsers"]=(int)Application["OnlineUsers"]>0? ((int)Application["OnlineUsers"] - 1) : 0;

            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}