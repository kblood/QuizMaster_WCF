using BLL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBUser
    {
        private Repository<User> repository = new Repository<User>();
        /// <summary>
        /// Inserts the given user into the database. OBS! Remember to hash the password first!
        /// </summary>
        /// <param name="user">The user that is to be inserted</param>
        public int InsertUser(User user)
        {
            var command = new SqlCommand();
            command.CommandText = @"INSERT INTO [User] (Username, Password, Salt) VALUES (@username, @password, @salt)";

            command.Parameters.AddWithValue("@username", user.Username);
            command.Parameters.AddWithValue("@password", user.Password);
            command.Parameters.AddWithValue("@salt", user.Salt);

            return repository.ExecuteStatement(command);
        }

        /// <summary>
        /// Extracts a user with a specific id from the database
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns>User</returns>
        public User GetById(int id)
        {
            var command = new SqlCommand();
            command.CommandText = "SELECT * FROM [User] WHERE Id = @id";
            command.Parameters.AddWithValue("@id", id);

            User user = repository.SingleRead(command);

            if (user.Id == 0)
            {
                return null;
            }

            return user;
        }

        /// <summary>
        /// Extracts a user with a specific username from the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns>user</returns>
        public User GetByName(string name)
        {
            var command = new SqlCommand();
            command.CommandText = @"SELECT * FROM [User] WHERE Username = @name";
            command.Parameters.AddWithValue("@name", name);

            return repository.SingleRead(command);
        }

        /// <summary>
        /// Runs the command in a reader and builds a user from the result
        /// </summary>
        /// <param name="command">the command that is to be run</param>
        /// <returns>user</returns>
        //private User GetObject(SqlCommand command)
        //{
        //    User user = new User();
        //    SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);

        //    if (reader.Read())
        //    {
        //        user = (User)(Repository.ReflectionObjectBuilder(reader, user));
        //        //user = ObjectBuilder(reader);
        //    }
        //    return user;
        //}

        /// <summary>
        /// An Object Builder class to build new object
        /// </summary>
        /// <param name="reader">a reader object with data from the database</param>
        /// <returns>a new user object</returns>
        //private User ObjectBuilder(SqlDataReader reader)
        //{
        //    User user = new User();
        //    user.Id = int.Parse(reader["Id"].ToString());
        //    user.Username = reader["Username"].ToString();
        //    user.Password = reader["Password"].ToString();
        //    return user;
        //}
    }
}
