using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace stock_taking_system.Models
{
    public class VehicleDAL
    {
        //Setup Connection String
        string connectionString = "Data Source=Nathan-Laptop;Initial Catalog=VEHICLESDB;Integrated Security=True;";

        //Retrieve All
        public IEnumerable<Vehicles> GetAllVehicles()
        {
            List<Vehicles> vechList = new List<Vehicles>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("Sp_GetAllVehicles", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Vehicles vh = new Vehicles();
                    vh.ID = Convert.ToInt32(dr["ID"].ToString());
                    vh.Make = dr["Make"].ToString();
                    vh.Model= dr["Model"].ToString();
                    vh.Price = Convert.ToInt32(dr["Price"].ToString());
                    vh.Features = dr["Features"].ToString();

                    vechList.Add(vh);
                }
                con.Close();
            }
            return vechList;
        }

        //Insert Vehicle
        public void AddVehicle(Vehicles vh)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Make", vh.Make);
                cmd.Parameters.AddWithValue("@Model", vh.Model);
                cmd.Parameters.AddWithValue("@Price", vh.Price);
                cmd.Parameters.AddWithValue("@Features", vh.Features);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Update Vehicle
        public void UpdateVehicle(Vehicles vh)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VehicleID", vh.ID);
                cmd.Parameters.AddWithValue("@Make", vh.Make);
                cmd.Parameters.AddWithValue("@Model", vh.Model);
                cmd.Parameters.AddWithValue("@Price", vh.Price);
                cmd.Parameters.AddWithValue("@Features", vh.Features);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //To Delete Vehicle
        public void DeleteVehicle(int? vhId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteVehicle", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VehicleID", vhId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //Get By Vehicle ID
        public Vehicles GetVehicleID(int? vhId)
        {
            Vehicles vh = new Vehicles();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetVehicleID", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VehicleID", vhId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    vh.ID = Convert.ToInt32(dr["ID"].ToString());
                    vh.Make = dr["Make"].ToString();
                    vh.Model = dr["Model"].ToString();
                    vh.Price = Convert.ToInt32(dr["Price"].ToString());
                    vh.Features = dr["Features"].ToString();

                    
                }
                con.Close();
            }
            return vh;
        }
    }
}
