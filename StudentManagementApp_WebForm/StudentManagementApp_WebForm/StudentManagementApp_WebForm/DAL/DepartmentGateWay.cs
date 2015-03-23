using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StudentManagementApp_WebForm.Models;

namespace StudentManagementApp_WebForm.DAL
{
    public class DepartmentGateWay:Gateway
    {
        public DepartmentGateWay(): base("StudentConnectionString")
        {

          
        }

        public int Insert(Department aDepartment)
        {
            var query = @"INSERT INTO Department VALUES('" + aDepartment.Code + "','" + aDepartment.Name+ "')";

            Command.CommandText = query;

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();

            return rowAffected;
        }


        public Department GetDepartmentByCode(string code)
        {
            Department aDepartment = null;
            var query = "SELECT * FROM Department WHERE Code = '" + code + "'";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
                aDepartment = new Department();
                aDepartment.ID = Convert.ToInt32(rdr["ID"]);
                aDepartment.Code= rdr["Code"].ToString();
                aDepartment.Name = rdr["Name"].ToString();               
                
            }

            rdr.Close();
            Connection.Close();
            return aDepartment;
        }

        public List<Department> GetAllDepartment()
        {
            List<Department> departments= new List<Department>();

            var query = "SELECT * FROM Department";

            Command.CommandText = query;

            Connection.Open();
            SqlDataReader rdr = Command.ExecuteReader();

            while (rdr.Read())
            {
                Department aDepartment = new Department();

                aDepartment.Code = rdr["Code"].ToString();
                aDepartment.Name = rdr["Name"].ToString();
                aDepartment.ID = Convert.ToInt32(rdr["ID"]);
                departments.Add(aDepartment);
            }

            rdr.Close();
            Connection.Close();

            return departments;
        }
    }
}