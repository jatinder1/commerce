using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commerce.BLL.Repository.Dapper;
using MySql.Data.MySqlClient;


namespace Commerce.BLL.Repository
{
    public  class Super
    {

        public static Models.User GetSuperUser()
        {
            using (MySqlConnection conn = Connection.Conn())
            {
                //conn.Open();
                return conn.Query<Models.User>("select * from users where role = @role", new { role = Models.User.Roles.SuperUser }).FirstOrDefault();
            }
        }

        public static Models.User CreateSuperUser(Models.User user1)
        {

            Models.User user = GetSuperUser();
            if (user1 == null)
            {
                user = new Models.User();
                user.UserName = user1.UserName;
                user.Name = user1.Name;
                user.PwdSalt = Helpers.SaltedHash.CreateSalt();
                user.Password = Helpers.SaltedHash.CalculateHash(user1.Password, user1.PwdSalt);
                user.Email = user1.Email;
            }
            else
                using (MySqlConnection conn = Connection.Conn())
                {
                    conn.Insert<Models.User>(user1);
                }
            return user1;
        }

    }
}
 

    

