using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.DataAccess
{
    public class VisitsDataAccessLayer : IVisits
    {
        private string connectionString;
        public VisitsDataAccessLayer(IConfiguration configuration)
        {
            connectionString = configuration["ConnectionStrings:DefaultConnection"];
        }

        //To View all visits details
        public IEnumerable<Visits> GetAllVisits()
        {
            //try
            //{
            List<Visits> lstvisits = new List<Visits>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Visits visit = new Visits();

                    visit.ID_Visit = Convert.ToInt32(rdr["ID_Visit"]);
                    visit.ID_Doctor = Convert.ToInt32(rdr["ID_Doctor"]);
                    visit.doc_surname = Convert.ToString(rdr["doc_surname"]);
                    visit.doc_name = Convert.ToString(rdr["doc_name"]);
                    visit.ID_Patient = Convert.ToInt32(rdr["ID_Patient"]);
                    visit.pat_surname = Convert.ToString(rdr["pat_surname"]);
                    visit.pat_name = Convert.ToString(rdr["pat_name"]);
                    visit.ID_Diag = Convert.ToInt32(rdr["ID_Diag"]);
                    visit.diag_name = Convert.ToString(rdr["diag_name"]);
                    visit.price = Convert.ToInt32(rdr["price"]);
                    object sqlDateTime = rdr["visit_date"];
                    visit.visit_date = (sqlDateTime == System.DBNull.Value)
                        ? (DateTime?)null
                        : Convert.ToDateTime(sqlDateTime);

                    lstvisits.Add(visit);
                }
                con.Close();
            }
            return lstvisits;
        
            //}
            //catch
            //{
            //    throw;
            }

            //To Add new visit record 
            public int AddVisits(Visits visits)
            {
                try
                {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                        SqlCommand cmd = new SqlCommand("AddVisit", con);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID_Visit", visits.ID_Visit);
                        cmd.Parameters.AddWithValue("@ID_Doctor", visits.ID_Doctor);
                        cmd.Parameters.AddWithValue("@ID_Patient", visits.ID_Patient);
                        cmd.Parameters.AddWithValue("@ID_Diag", visits.ID_Diag);
                        cmd.Parameters.AddWithValue("@price", visits.price);
                        cmd.Parameters.AddWithValue("@visit_date", visits.visit_date);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    return 1;
                }
                catch
                {
                    throw;
                }
            }

        public int UpdateVisits(Visits visits)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("UpdateVisit", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Visit", visits.ID_Visit);
                    cmd.Parameters.AddWithValue("@ID_Doctor", visits.ID_Doctor);
                    cmd.Parameters.AddWithValue("@ID_Patient", visits.ID_Patient);
                    cmd.Parameters.AddWithValue("@ID_Diag", visits.ID_Diag);
                    cmd.Parameters.AddWithValue("@price", visits.price);
                    cmd.Parameters.AddWithValue("@visit_date", visits.visit_date);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public int DeleteVisits(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("DeleteVisit", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Visit", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return 1;
            }
            catch
            {
                throw;
            }
        }

        public Visits GetVisitsData(int id)
        {
            try
            {
                Visits visits = new Visits();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string sqlQuery = "SELECT * FROM Visits WHERE ID_Visit= " + id;
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        visits.ID_Visit = Convert.ToInt32(rdr["ID_Visit"]);
                        visits.ID_Doctor = Convert.ToInt32(rdr["ID_Doctor"]);
                        visits.ID_Patient = Convert.ToInt32(rdr["ID_Patient"]);
                        visits.ID_Diag = Convert.ToInt32(rdr["ID_Diag"]);
                        visits.price = Convert.ToInt32(rdr["price"]);
                        object sqlDateTime = rdr["visit_date"];
                        visits.visit_date = (sqlDateTime == System.DBNull.Value)
                            ? (DateTime?)null
                            : Convert.ToDateTime(sqlDateTime);
                    }
                }
                return visits;
            }
            catch
            {
                throw;
            }
        }

    }
}
