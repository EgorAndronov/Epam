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

        public void Add(Award award)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var commandAdd = sqlConnection.CreateCommand();
                commandAdd.CommandText = "AddAward";
                commandAdd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterTitle = new SqlParameter("@Title", award.Title);
                commandAdd.Parameters.Add(parameterTitle);


                sqlConnection.Open();
                commandAdd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);


                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Award> Get()
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllAwards";
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var award = new Award
                    {
                        Id = (int)reader["Id"],
                        Title = (string)reader["Title"],
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
