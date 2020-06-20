using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Day21_MD
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
            database = "university";
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

        public void GetStudents()
        {
            string stm = "SELECT studentID, studentName, studentLastName, studentCours FROM student";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            dataAdapter.SelectCommand = new MySqlCommand(stm, connection);

            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row.Field<int>(0) + " " + row.Field<String>(1) + " " + row.Field<String>(2) + " " + row.Field<int>(3));
            }

        }

        public void AddStudent(University student)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "INSERT INTO student (studentName,studentLastName,studentCours) " +
                    "VALUES(@studentName,@studentLastname,@studentCours)";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@studentName", student.getName());
                cmd.Parameters.AddWithValue("@studentLastName", student.getLastName());
                cmd.Parameters.AddWithValue("@studentCours", student.getCours());
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        public void DeleteStudentById(int studentID)
        {
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM student WHERE studentID = " + studentID;
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }
    }
}
