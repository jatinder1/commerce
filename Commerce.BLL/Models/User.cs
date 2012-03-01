using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.BLL.Models
{
    public class User
    {
        public enum Roles
        {
            SuperUser = 1, StoreUser, Buyer
        }
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string PasswordHash { get; set; }

        public string Salt { get; set; }


    }
}
