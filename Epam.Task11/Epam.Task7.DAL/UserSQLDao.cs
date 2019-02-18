using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
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
    public class UserSQLDao : IUserDao
    {
        private string _connectionString;

        public UserSQLDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public IEnumerable<User> Get()
        {
            var result = new List<User>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM Users";
                command.CommandType = CommandType.Text;
                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var user = new User
                    {
                        Id = (int)reader["id"],
                        Name = (string)reader["name"],
                        DateofBirth = (DateTime)reader["dateofbirth"],
                    };
                    result.Add(user);
                }
            }
            return result;
        }

        public void Save(ICacheLogic<int, User> cacheLogic)
        {
            throw new NotImplementedException();
        }
    }
}
