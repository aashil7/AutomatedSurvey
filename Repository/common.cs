using AutomatedSurvey.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AutomatedSurvey.Repository
{
    public class common
    {

        public SqlConnection con;


        private void Connection()
        {
            string _conString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            con = new SqlConnection(_conString);

        }

        //public List<State_list> GetState()
        //{
        //    List<State_list> appRefDataList = new List<State_list>();
        //    Connection();
        //    SqlCommand cmd = new SqlCommand("surveytable_Aashil", con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    con.Open();

        //    SqlDataReader reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        appRefDataList.Add(
        //            new surveydata { Id = Convert.ToInt32(reader["State_ID"]), Name = reader["State_Name"].ToString() }
        //            );
        //    }

        //    reader.Close();
        //    con.Close();

        //    return appRefDataList;
        //}







    }
}