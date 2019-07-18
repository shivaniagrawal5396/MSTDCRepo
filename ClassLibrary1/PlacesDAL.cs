using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL;
namespace DAL
{
    public class PlacesDAL
    {
        public bool Insert(Places NewPlace)
        {
            // bool status = false;
            SqlConnection cn = new SqlConnection("Data Source = platow42l0274; Initial Catalog = MSTDCdb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("[sp_insertplaces]", cn);
            cmd.Parameters.AddWithValue("@p_pname", NewPlace.PlaceName);
            cmd.Parameters.AddWithValue("@p_pdesc", NewPlace.PlaceDescription);
            cmd.Parameters.AddWithValue("@p_plat", NewPlace.PlaceLat);
            cmd.Parameters.AddWithValue("@p_plong", NewPlace.PlaceLan);
            cmd.Parameters.AddWithValue("@p_pplacetype", NewPlace.PlaceType);
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
        public bool Delete(Places NewPlace)
        {
            // bool status = false;
            SqlConnection cn = new SqlConnection("Data Source = platow42l0274; Initial Catalog = MSTDCdb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("[sp_deleteplaces]", cn);
            cmd.Parameters.AddWithValue("@p_pname", NewPlace.PlaceName);
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

        public bool Update(Places NewPlace)
        {
            // bool status = false;
            SqlConnection cn = new SqlConnection("Data Source = platow42l0274; Initial Catalog = MSTDCdb; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("[sp_updateplaces]", cn);
            cmd.Parameters.AddWithValue("@p_pname", NewPlace.PlaceName);
            cmd.Parameters.AddWithValue("@p_pdesc", NewPlace.PlaceDescription);
            cmd.Parameters.AddWithValue("@p_plat", NewPlace.PlaceLat);
            cmd.Parameters.AddWithValue("@p_plong", NewPlace.PlaceLan);
            cmd.Parameters.AddWithValue("@p_pplacetype", NewPlace.PlaceType);
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
