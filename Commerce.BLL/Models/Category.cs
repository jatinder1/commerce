using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commerce.BLL.Models
{
    public class Category
    {
        public int CategoryId {get; set;}
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Active { get; set; }
    }
}