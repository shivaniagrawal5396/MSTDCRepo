using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
namespace DAL
{
    public class LoginDAL
    {
        public bool ValidateUser(Login login)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=PLATOW42S2430;Initial Catalog=MSTDC;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand("[sp_login]", cn);
            cmd.Parameters.AddWithValue("@p_lemail", login.Email);
            cmd.Parameters.AddWithValue("@p_lpassword", login.Password);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            bool s = dr.Read();
            if (s)
            {
                if (dr.HasRows)
                {
                    status = true;
                }
            }
            cn.Close();
            return status;
        }

        public bool SignUp(Signup newuser)
        {
            bool status = false;
            SqlConnection cn = new SqlConnection("Data Source=PLATOW42S2430;Initial Catalog=MSTDC;Integrated Security=True"); ;
            SqlCommand cmd = new SqlCommand("[sp_insertUsers]", cn);
            cmd.Parameters.AddWithValue("@emid", newuser.Name);
            cmd.Parameters.AddWithValue("@name", newuser.Email);
            cmd.Parameters.AddWithValue("@name", newuser.Password);
            cmd.Parameters.AddWithValue("@name", newuser.Gender);
            cmd.Parameters.AddWithValue("@name", newuser.DOB);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            cmd.ExecuteNonQuery();
            return true;
        }

 
    }
}
