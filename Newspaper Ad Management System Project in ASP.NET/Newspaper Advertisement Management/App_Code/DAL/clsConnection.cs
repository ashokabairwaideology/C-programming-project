﻿using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for clsConnection
/// </summary>
public class clsConnection
{
	public clsConnection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string Connection
    {
        get 
        {
            return ConfigurationManager.ConnectionStrings["newspaper"].ConnectionString;
        }
    }
}
