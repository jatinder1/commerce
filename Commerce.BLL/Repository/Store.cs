using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Commerce.BLL.Repository.Dapper;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;



namespace Commerce.BLL.Repository
{
   public static class Store
    {
       //public static Models.Store GetStore()
       //{
       //    using (MySqlConnection Conn = Connection.Conn())
       //    {
       //        return Conn.Query<Models.Store>("select * from Stores where role=@role", new { role = Models.Store.Roles.StoreUser }).FirstOrDefault();

       //    }
       //}
       //public static Models.Store CreateStore()
       //{
       //    Models.Store Store = GetStore();
       //    if (Store == null)
       //    {
       //        Store = new Models.Store();
       //        Store.StoreName = "Store";
       //        Store.Name = "Adidas";
       //        Store.PasswordHash = "";
       //        Store.Salt = "";
       //        using (MySqlConnection conn = Connection.Conn())
       //        {
       //            conn.Insert<Models.Store>(Store);
       //        }
       //        return Store;
       //    }
       //}
     
    }
}
