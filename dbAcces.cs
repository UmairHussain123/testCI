using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Api
{
    public class DBAccess
    {
       static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-ENT3TDE\SQLEXPRESS;Initial Catalog=Person_Data;Integrated Security=True");

        public static int Sql(string Query, int roll, string name, int Gpa, string dep)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(Query,con);
            cmd.Parameters.AddWithValue("@ROll_NUM", roll);
            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@GPA", Gpa);
            cmd.Parameters.AddWithValue("@DEPT", dep);
            int result = cmd.ExecuteNonQuery();
            return result;

        }
    }
}