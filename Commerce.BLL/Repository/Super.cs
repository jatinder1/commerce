using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commerce.BLL.Repository.Dapper;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Security;
using Commerce.BLL.Repository;
using Commerce.BLL.Helpers;



namespace Commerce.BLL.Repository
{
    public static class Super
    {
        public static Models.User GetSuperUser()
        {
            using (MySqlConnection conn = Connection.Conn())
            {
               return conn.Query<Models.User>("select * from users where role = @role", new {role = Models.User.Roles.SuperUser }).FirstOrDefault();
            }
        }
       

        public static Models.User CreateSuperUser()
        {
            Models.User user = GetSuperUser();
            if (user== null)
            {
                user = new Models.User();
                user.UserName = "super";
                user.Name = "Ankit";
                user.PwdSalt = "";
                user.Password = Helpers.SaltedHash.Create(user.PwdSalt);
                user.Email="email";
                
                
                using (MySqlConnection conn = Connection.Conn())
                {
                    conn.Insert<Models.User>(user);
                }
            }
            return user;
        }

        private static string CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            
            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }
        private static string CreatePasswordHash(string pwd, string salt)
        {
            string saltAndPwd = String.Concat(pwd, salt);
            string hashedPwd =FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
            return hashedPwd;
        }
    }
}
