using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.BLL.Models
{
    public class Store
    {
        public enum Roles
        {
            StoreUser= 1,SuperUser,Buyer
        }
        public int StoreId { get; set; }
        public string Name { get; set; }
        public string StoreName { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
    }
}
