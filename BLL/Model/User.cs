using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BLL.Model
{
    /// <summary>
    /// A class for the teacher/Admin of the quizes.
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Username { get; set; }

        public string Password { get; set; }
        public string Salt { get; set; }


        /// <summary>
        /// Initializes a user with the given parameters.
        /// </summary>
        public User(string username, string password) : base()
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Initializes an empty user.
        /// </summary>
        public User()
        {

        }
        /// <summary>
        /// Generate random salt from random characters
        /// </summary>
        /// <returns>results string with a random generated salt</returns>
        public string CreateSalt()
        {
            //Generates a random lenght from lenght between 4 & 10
            Random randomLenght = new Random();
            int length = randomLenght.Next(4, 10);

            //characters useed to create a random salt
            const string character = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            //StringBuilder Builds the  results
            StringBuilder result = new StringBuilder();
            //Generates a random value from lenght 
            Random random = new Random();
            while (0 < length--)
            {
                result.Append(character[random.Next(character.Length)]);
            }          
            return result.ToString();
        }

        /// <summary>
        /// Hashes the password of the user & adds random generated salt to password.
        /// </summary>
        public void HashPassword()
        {
            Salt = CreateSalt();
            Password = HashThisPassword(Salt+Password);
        }

        /// <summary>
        /// Hashes the given password.
        /// </summary>
        public static string HashThisPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return string.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
