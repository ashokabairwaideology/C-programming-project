using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveDocs.backend.database
{
    /// <summary>
    /// Configuration and utility class for Database Setup
    /// </summary>
    public class Database
    {
        public const string Username = "livedocsuser";
        public const string Password = "dat219";
        public const string Host = "greblak.no-ip.org";
        public const string Schema = "livedocs";

        public static string ConnectionString =
            "SERVER=" + Host + ";" +
            "DATABASE=" + Schema + ";" +
            "UID=" + Username + ";" +
            "PASSWORD=" + Password + ";";
    }
}