using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

        public void Add(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var commandAdd = sqlConnection.CreateCommand();
                commandAdd.CommandText = "AddUser";
                commandAdd.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterName = new SqlParameter("@Name", user.Name);
                commandAdd.Parameters.Add(parameterName);

                SqlParameter parameterDateOfBirthday = new SqlParameter("@DateOfBirthday", user.DateofBirth);
                commandAdd.Parameters.Add(parameterDateOfBirthday);

                sqlConnection.Open();
                commandAdd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);


                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> Get()
        {
            var result = new List<User>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAllUsers";
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new User
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        DateofBirth = (DateTime)reader["DateOfBirthday"],
                    });
                }
            }
            return result;
        }

        public User GetById(int id)
        {
            var result = new User();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUser";
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result.Id = (int)reader["Id"];
                    result.Name = (string)reader["Name"];
                    result.DateofBirth = (DateTime)reader["DateOfBirthday"];
                }
            }
            return result;
        }

        public void AddAwardForUser(int idUser, int idAward)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddAwardForUser";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterIdUser = new SqlParameter("@IdUser", idUser);
                command.Parameters.Add(parameterIdUser);

                SqlParameter parameterIdAward = new SqlParameter("@IdAward", idAward);
                command.Parameters.Add(parameterIdAward);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<IEnumerable<int>> GetUserAward()
        {
            var result = new List<List<int>>();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetUsersAwards";
                command.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();

                var reader = command.ExecuteReader();
                while (reader.Read())
                {

                    result.Add(new List<int> { (int)reader["IdUsers"], (int)reader["IdAwards"] });

                }
            }
            return result;
        }

        public void Update(User user)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UsersUpdate";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterIdUser = new SqlParameter("@Id", user.Id);
                command.Parameters.Add(parameterIdUser);

                SqlParameter parameterName = new SqlParameter("@Name", user.Name);
                command.Parameters.Add(parameterName);

                SqlParameter parameterDateOfBirthday = new SqlParameter("@DateOfBirthday", user.DateofBirth);
                command.Parameters.Add(parameterDateOfBirthday);

                sqlConnection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void PutImageOfUser(int id, string pathFile)
        {
            string base64 = null;
            string path = Path.Combine(new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).FullName, "img", pathFile);
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    image.Save(stream, image.RawFormat);
                    byte[] imageBytes = stream.ToArray();
                    base64 = Convert.ToBase64String(imageBytes);
                }
            }

            string screenFormat = (Path.GetExtension(pathFile)).Replace(".", "").ToLower();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddUserPhoto";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterIdUser = new SqlParameter("@IdUser", id);
                command.Parameters.Add(parameterIdUser);

                SqlParameter parameterScreen = new SqlParameter("@screen", base64);
                command.Parameters.Add(parameterScreen);
                SqlParameter parameterScreenFormat = new SqlParameter("@screen_format", screenFormat);
                command.Parameters.Add(parameterScreenFormat);
                sqlConnection.Open();
                command.ExecuteNonQuery();

            }

        }

        public Image GetImageBase64FromDb(int id)
        {
            
            List<string> iScreen = new List<string>(); 
            List<string> iScreen_format = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                
                SqlCommand command = new SqlCommand();
                command.Connection = sqlConnection;
                command.CommandText = "GetPhoto";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterIdUser = new SqlParameter("@IdUser", id);
                command.Parameters.Add(parameterIdUser);

                sqlConnection.Open();
                var reader = command.ExecuteReader();
                string iTrimText = null;
                while (reader.Read()) 
                {
                    iTrimText = reader["screen"].ToString().TrimStart().TrimEnd(); 
                    iScreen.Add(iTrimText);
                    iTrimText = reader["screen_format"].ToString().TrimStart().TrimEnd(); 
                    iScreen_format.Add(iTrimText);
                }
                
            }

            
            string base64StringImage = iScreen[0];
            byte[] imageData = Convert.FromBase64String(base64StringImage);
            MemoryStream ms = new MemoryStream(imageData);
            Image newImage = Image.FromStream(ms);

            return newImage;
        }

        public void Save(ICacheLogic<int, User> cacheLogic)
        {
            
        }


    }
}

