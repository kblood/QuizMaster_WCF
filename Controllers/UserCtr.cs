using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using BLL.Model;
using DAL;

namespace Controllers
{
    public class UserCtr
    {
        /// <summary>
        /// Takes a username and an un-hashed password from the WCF, and returns a the corrosponding user, if there is a user with that username and password in the Database. Otherwise, returns null.
        /// </summary>
        public User ValidateUser(String username, string unHashedPassword)
        {
            DBUser dbUser = new DBUser();
            User user = dbUser.GetByName(username);

            //Salt added to unHashedPassword
            if (user != null && user.Password != User.HashThisPassword(user.Salt+unHashedPassword))
            {
                user = null;
            }
            return user;
        }

        /// <summary>
        /// Takes a username and password, creates a new user. hashed the password and call db insert, to save the new user to database.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public int InsertUser(string username, string password)
        {
            User user = new User(username, password);
            user.HashPassword();
            DBUser dbUser = new DBUser();
            try
            {
                return dbUser.InsertUser(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                throw ex;
            }
        }

        public int GetUserID(string username)
        {
            DBUser dbUser = new DBUser();
            
            try
            {
                User user = dbUser.GetByName(username);
                if(user == null)
                {
                    return 0;
                }
                return user.Id;

            }
            catch (Exception e)
            {

                throw e;
            }


        }
    }
}
