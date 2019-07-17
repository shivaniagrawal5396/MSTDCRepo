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
            SqlConnection cn = new SqlConnection("Data Source = platow42l0274; Initial Catalog = MSTDCdb; Integrated Security = True"); 
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
           // bool status = false;
            SqlConnection cn = new SqlConnection("Data Source = platow42l0274; Initial Catalog = MSTDCdb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("[sp_insertUsers]", cn);
            cmd.Parameters.AddWithValue("@p_uname", newuser.Name);
            cmd.Parameters.AddWithValue("@p_uemail", newuser.Email);
            cmd.Parameters.AddWithValue("@p_upassword", newuser.Password);
            cmd.Parameters.AddWithValue("@p_ugender", newuser.Gender);
            cmd.Parameters.AddWithValue("@p_udob", newuser.DOB);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cn.Open();
            int rows = cmd.ExecuteNonQuery();
            bool status = false;
            if (rows == -1)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            cn.Close();
            return status;
        }

 
    }
}
