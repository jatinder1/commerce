using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Commerce.Web.Models
{
    public class ChangePassword
    {
        public string  OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string ConfirmPassword { get; set; }
    }
    public class Login
    {
        public string UserName { get; set; }
        public string Passwprd { get; set; }
        public bool RememberMe { get; set; }
    }
    public class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
    }
}