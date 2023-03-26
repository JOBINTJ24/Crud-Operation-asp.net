using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Crud_Operation.Models;
using System.Drawing;

namespace Crud_Operation.Databse
{
    public class db
    {
        SqlConnection sql = new SqlConnection("Data Source=LAPTOP-FVJ93DIM;Initial Catalog=employees;Integrated Security=True");
         public void add_record(student student)
        {
            SqlCommand cmd = new SqlCommand("StudenCrud_MVC", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", student.id);
            cmd.Parameters.AddWithValue("@sname", student.Sname);
            cmd.Parameters.AddWithValue("@email", student.Email);
            cmd.Parameters.AddWithValue("@phone", student.Phone);
            cmd.Parameters.AddWithValue("@department", student.department);
            cmd.Parameters.AddWithValue("@choice", student.choice);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }


        public void update_record(student student)
        {
            SqlCommand cmd = new SqlCommand("StudenCrud_MVC", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", student.id);
            cmd.Parameters.AddWithValue("@sname", student.Sname);
            cmd.Parameters.AddWithValue("@email", student.Email);
            cmd.Parameters.AddWithValue("@phone", student.Phone);
            cmd.Parameters.AddWithValue("@department", student.department);
            cmd.Parameters.AddWithValue("@choice", student.choice);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }

        public DataSet Data_Views(string choice)
        {
            SqlCommand cmd = new SqlCommand("StudenCrud_MVC", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@choice", choice);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


        public void delete_record(int id, string choice)
        {
            SqlCommand cmd = new SqlCommand("StudenCrud_MVC", sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@choice", choice);
            sql.Open();
            cmd.ExecuteNonQuery();
            sql.Close();
        }


        public DataSet Show_recod_byid(int id,string choice)
        {
            SqlCommand cmd = new SqlCommand("StudenCrud_MVC",sql);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@choice",choice);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
}