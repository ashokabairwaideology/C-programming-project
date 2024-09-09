using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class admin_Create_employee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string EId = EID.Text;
        string EFname = E_FNAME.Text;
        string ELname = E_LNAME.Text;
        string email = EMAIL.Text;
        string password = PSWRD.Text;
        string addres = ADDRS.Text;
        string mobile = MOBILE.Text;
        string city = CITY.Text;
        string state = STATE.Text;
        string zip = ZIP.Text;
        string dob = DOB.Text;
        string doj = DOJ.Text;
        string position = ddl_position.Text;
        string status = "Active";
        string pv_company = PRVCMPNY.Text;

        string myQuery = "insert into Emp_info values('" + EId + "','" + EFname + "','" + ELname + "','" + email + "','" + password + "','" + addres + "','" + mobile + "','" + city + "','" + state + "','" + zip + "','" + dob + "','" + doj + "','" + position + "','" + status + "','" + pv_company + "')";
        DAL.SqlHelper.ExecuteNonQuery(clsConnection.Connection, CommandType.Text, myQuery);
        //Response.Redirect("~/admin/Create_employees.aspx");

        EID.Text = "";
        E_FNAME.Text = "";
        E_LNAME.Text = "";
        EMAIL.Text = "";
        PSWRD.Text = "";
        ADDRS.Text = "";
        MOBILE.Text = "";
        CITY.Text = "";
        STATE.Text = "";
        ZIP.Text = "";
        DOB.Text = "";
        DOJ.Text = "";
        PRVCMPNY.Text = "";
        CNF_PWD.Text = "";

        lbl_insert.Visible = true;
        lbl_insert.Text = "Employee Added Sucessfully......";





    }

    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        string empid = EID.Text;


        {
            string qry = "select * from Emp_info where Emp_Id='" + empid + "'";
            DataSet ds = new DataSet();
            ds = DAL.SqlHelper.ExecuteDataset(clsConnection.Connection, CommandType.Text, qry);
            if (ds.Tables[0].Rows.Count == 0)
            {
                label_check.Visible = true;
                label_check.Text = "EMPLOYEE ID Avilable....";
                


            }
            else
            {

                label_check.Visible = true;
                label_check.Text = "ID NotAvilable";
                
            }
        }
    }
}

    