using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Databaseclass
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGBUILT\\SQLEXPRESS;Initial Catalog=toyotacompany;Integrated Security=True;Encrypt=False");
        DataTable dt = new DataTable();

        public DataTable select()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Select VehicleID,Model,Engine,Color ,SeatingCapacity ,EngineType ,Transmission,Maxspeed ,Gearbox from Toyota", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally { conn.Close(); }
            return dt;
        }
    }
}
