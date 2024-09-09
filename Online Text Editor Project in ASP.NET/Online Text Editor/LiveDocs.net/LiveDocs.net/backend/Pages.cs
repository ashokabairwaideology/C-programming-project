using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace LiveDocs.backend
{
    public class Pages
    {
        //Check page accesslevel.
        public static bool CheckAccess(int UserLevel, Page page)
        {            
            if (HttpContext.Current.Request.Path.StartsWith("/public") || HttpContext.Current.Request.Path.Count(f => f == '/') == 1)
                return true;
            if (HttpContext.Current.Request.Path.StartsWith("/livedocs") && UserLevel >= 1)
                return true;
            if (HttpContext.Current.Request.Path.StartsWith("/admin") && UserLevel >= 2)
                return true;

            return false;
        }
        private static Control FindControlIterative(Control root,string id)
        {
            Control ctl = root;
            LinkedList<Control> ctls = new LinkedList<Control>();


            while (ctl != null)
            {
                if (ctl.ID == id)
                    return ctl;
                foreach (Control child in ctl.Controls)
                {
                    if (child.ID == id)
                        return child;
                    if (child.HasControls())
                        ctls.AddLast(child);
                }
                ctl = ctls.First.Value;
                ctls.Remove(ctl);
            }
            return null;
        }
    }
}