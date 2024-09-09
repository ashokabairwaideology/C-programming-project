using System;
using System.Data;
using System.Data.SqlClient;

public class ThreadDAL
{
    public static string AddNewThread(string uid, string subcode, string text)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("AddNewThread", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@subcode", SqlDbType.Int).Value = subcode;
            cmd.Parameters.Add("@text", SqlDbType.Text).Value = text;
            cmd.ExecuteNonQuery();
            return null;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public static string AddReply(string uid, string tid, string text)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("AddReply", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            cmd.Parameters.Add("@tid", SqlDbType.Int).Value = tid;
            cmd.Parameters.Add("@text", SqlDbType.Text).Value = text;
            cmd.ExecuteNonQuery();
            return null;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
        finally
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }

    public static DataSet Search(string cond)
    {
        SqlConnection con = new SqlConnection(Database.ConnectionString);
        try
        {
            SqlDataAdapter da = new SqlDataAdapter(" SELECT t.tid, u.uid, u.fullname, s.subname, CONVERT(varchar(30), t.text) AS text, t.dp, dbo.GetReplyCount(t.tid) AS noreplys FROM threads AS t INNER JOIN  users AS u ON t.uid = u.uid INNER JOIN  subjects AS s ON t.subcode = s.subcode WHERE (t.sno = 1) AND " + cond, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "threads");
            return ds;
        }
        catch (Exception ex)
        {
            return null;
        }
    }

}
