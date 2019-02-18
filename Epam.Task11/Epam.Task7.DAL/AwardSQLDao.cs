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
    public class AwardSQLDao : IAwardDao
    {
        private string _connectionString;

        public AwardSQLDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public IEnumerable<Award> Get()
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM Awards";
                command.CommandType = CommandType.Text;
                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var award = new Award
                    {
                        Id = (int)reader["id"],
                        Title = (string)reader["title"],
                    };
                    result.Add(award);
                }
            }
            return result;
        }

        public void Save(ICacheLogic<int, Award> cacheLogic)
        {
            throw new NotImplementedException();
        }
    }
}
