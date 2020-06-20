using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Day22_MySql
{
    class DBConnection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        public DBConnection()
        {
            server = "127.0.0.1";
            database = "ofiss";
            user = "Chris";
            password = "open1234";
            port = "3306";
            sslM = "none";

            connectionString = String.Format("server={0};port={1};user id={2};password={3};database={4};SslMode={5}", server, port, user, password, database, sslM);

            connection = new MySqlConnection(connectionString);
        }

        public void Connect()
        {
            try
            {
                connection.Open();

                Console.WriteLine("Success");

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void GetEmployees()
        {
            string stm = "SELECT employeeId, employeeName, employeeLastName, departamentId, jobId, jsalary FROM employees";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<String>(0) + " " + row.Field<String>(1));
            }
        }

        public void SetEmployees(String _name, String _lastName, String _depId, int _salary, int _jobId)
        {
            string ins = $"INSERT INTO employees(employeeName, employeeLastName, departmentId, jobId, jsalary) " +
                $"VALUES ({_name}, {_lastName}, {_depId}, {_jobId}, {_salary})";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = $"INSERT INTO employees(employeeName, employeeLastName, departmentId, jobId, jsalary) " +
                $"VALUES ({_name}, {_lastName}, {_depId}, {_jobId}, {_salary})";
                cmd.Prepare();

                cmd.Parameters.AddWithValue($"{_name}", _name);
                cmd.Parameters.AddWithValue($"{_lastName}", _lastName);
                cmd.Parameters.AddWithValue($"{_depId}", _depId);
                cmd.Parameters.AddWithValue($"{_jobId}", _jobId);
                cmd.Parameters.AddWithValue($"{_salary}", _salary);
                cmd.ExecuteNonQuery();

            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
