using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace gridViewExample.DAL
{
    public class CRUD
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["hospitalsConnectionString"].ToString());

        public DataTable GetHospitals()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hospitals", con);
            da.Fill(dt);
            return dt;

        }

        public string DelHos(int id)
        {

            string message = "Deletion successful!";

            SqlCommand cmd = new SqlCommand("DELETE FROM Hospitals WHERE id = '" + id + "'", con);
            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                return message;

            }

            catch
            {

                message = "Deletion failed, try again!";
                return message;

            }
            finally
            {

                con.Close();

            }

        }

        public string UpdateHos(int id, string name, string city)
        {

            string message = "Update successful!";

            SqlCommand cmd = new SqlCommand("UPDATE Hospitals SET name='" + name + "', city='" + city + "' WHERE id = '" + id + "'", con);
            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                return message;

            }

            catch
            {

                message ="Update failed. There may be a server error, please try again later.";
                return message;


            }
            finally
            {

                con.Close();

            }

        }

    }
}