using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Commerce.BLL.Models
{
    public class Login
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe {get; set;}
    }
    public class ChangePassword
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword {get; set; }
        public string Email {get; set; }
    }
}
