﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyNewProject.Ado_with_SQL
{
    static class DBconnect
    {
        public static SqlConnection getConnection()
        {
            string str = "server=DESKTOP-46PU1N7;Database=ThinkQutient;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlc = new SqlCommand("select*from newemp2", con);
                SqlDataReader dr = sqlc.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("id==" + dr[0] + " " + "name==" + dr[1] + " " + "salary==" + dr[2] + " " + "city==" + dr[3]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return con;
        }
    }
    class Demoinsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBconnect.getConnection();
            Console.WriteLine("Enter percent dept");
            float id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into newemp2 values(@perc,@dept");
            cmd.Parameters.AddWithValue("@perc", 88);
            cmd.Parameters.AddWithValue("@dept", "chem");
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record inserted");
            Console.ReadLine();
        }
    }    
    class Sql_demo
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-46PU1N7;Database=ThinkQutient;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand sqlc = new SqlCommand("select * from newemp2",con);
                SqlDataReader dr=sqlc.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("ename=" + dr["name"] + "salary=" + dr["sal"] + "city="+dr[4]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (con != null)
                    con.Close();

            }
            Console.ReadLine();

        }
        
        
    }

   
    
}
