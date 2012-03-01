using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commerce.BLL.Repository.Dapper;
using MySql.Data.MySqlClient;
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
                user.Name = "Ankit Patial";
                user.PasswordHash = "";
                user.Salt = "";
                using (MySqlConnection conn = Connection.Conn())
                {
                    conn.Insert<Models.User>(user);
                }
            }
            return user;
        }

    }
}
