using Epam.Task7.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL
{
    public class RegisteredUsersDao : IRegisteredUsersDao
    {
        private string _connectionString;

        public RegisteredUsersDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(string logIn, string password)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddRegisteredUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterLogIn = new SqlParameter("@LogIn", logIn);
                command.Parameters.Add(parameterLogIn);

                SqlParameter parameterPassword = new SqlParameter("@Password", password);
                command.Parameters.Add(parameterPassword);

                
                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public bool Exist(string login, string password)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                string localPassword = string.Empty;
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetPasswordUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterLogIn = new SqlParameter("@LogIn", login);
                command.Parameters.Add(parameterLogIn);

                sqlConnection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    localPassword = (string)reader["Password"];
                }
                return password == localPassword;
            }
        }

    }
}
