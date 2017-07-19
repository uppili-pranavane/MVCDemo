using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BussinessLayer
{
    public class EmployeeBussinessLayer
    {
       public IEnumerable<Employee> Employee
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                List<Employee> employees = new List<Employee>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmployees", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee . Id     = Convert.ToInt32(rdr["Id"]);
                        employee . AceId  = rdr["AceId"].ToString();
                        employee . Name   = rdr["Name"].ToString();
                        employee . Email  = rdr["Email"].ToString();
                        employee . Mobile = rdr["Mobile"].ToString();
                        employee . Steam  = rdr["Steam"].ToString();

                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }


        public void AddEmployee(Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraAceId = new SqlParameter();
                paraAceId.ParameterName = "@AceId";
                paraAceId.Value = employee.AceId;
                cmd.Parameters.Add(paraAceId);


                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);


                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@Email";
                paraEmail.Value = employee.Email;
                cmd.Parameters.Add(paraEmail);


                SqlParameter paraMobile = new SqlParameter();
                paraMobile.ParameterName = "@Mobile";
                paraMobile.Value = employee.Mobile;
                cmd.Parameters.Add(paraMobile);


                SqlParameter paraSteam = new SqlParameter();
                paraSteam.ParameterName = "@Steam";
                paraSteam.Value = employee.Steam;
                cmd.Parameters.Add(paraSteam);


                con.Open();
                cmd.ExecuteNonQuery();


            }

        }


        public void SaveEmployee ( Employee employee)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraId = new SqlParameter();
                paraId.ParameterName = "@Id";
                paraId.Value = employee.Id;
                cmd.Parameters.Add(paraId);

                SqlParameter paraAceId = new SqlParameter();
                paraAceId.ParameterName = "@AceId";
                paraAceId.Value = employee.AceId;
                cmd.Parameters.Add(paraAceId);


                SqlParameter paraName = new SqlParameter();
                paraName.ParameterName = "@Name";
                paraName.Value = employee.Name;
                cmd.Parameters.Add(paraName);


                SqlParameter paraEmail = new SqlParameter();
                paraEmail.ParameterName = "@Email";
                paraEmail.Value = employee.Email;
                cmd.Parameters.Add(paraEmail);


                SqlParameter paraMobile = new SqlParameter();
                paraMobile.ParameterName = "@Mobile";
                paraMobile.Value = employee.Mobile;
                cmd.Parameters.Add(paraMobile);


                SqlParameter paraSteam = new SqlParameter();
                paraSteam.ParameterName = "@Steam";
                paraSteam.Value = employee.Steam;
                cmd.Parameters.Add(paraSteam);


                con.Open();
                cmd.ExecuteNonQuery();


            }
        }


        public void DeleteEmployee( int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paraId = new SqlParameter();
                paraId.ParameterName = "@Id";
                paraId.Value = id;
                cmd.Parameters.Add(paraId);


                con.Open();
                cmd.ExecuteNonQuery();

            }
        }
    }
}
