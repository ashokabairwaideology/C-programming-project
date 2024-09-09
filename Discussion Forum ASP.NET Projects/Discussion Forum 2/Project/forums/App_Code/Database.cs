using System;
using System.Data;
using System.Configuration;
using System.Web.Configuration;

public class Database
{
    public static string ConnectionString
    {
        get
        {
            return WebConfigurationManager.ConnectionStrings["ForumsConnectionString"].ConnectionString;
        }
    }

}
