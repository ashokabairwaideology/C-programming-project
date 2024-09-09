using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LiveDocs.backend.document
{
    
    public static class UsernameVerifier //Check that username follows naming convention.
    {
        public static readonly string RegexMail = @"^(([^<>()[\]\\.,;:\s@\""]+"

                        + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"

                        + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"

                        + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"

                        + @"[a-zA-Z]{2,}))$";
       public static bool VerifyMail(string email)
       {

           Match match = Regex.Match(email, RegexMail);
           if(match.Success)
           {
               return true;
           }
            return false;
        }

    }
}