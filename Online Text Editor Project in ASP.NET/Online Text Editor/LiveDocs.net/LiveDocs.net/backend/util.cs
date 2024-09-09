using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
namespace LiveDocs.backend
{
    //Utility functions
    static internal class Util
    {
        public static string GenerateRandomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)])
                    .ToArray());
            return result;
        }
        public static Control FindControlIterative(Control root,string id)
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
