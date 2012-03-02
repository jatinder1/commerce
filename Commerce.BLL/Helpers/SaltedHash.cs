using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Security.Cryptography;

namespace Commerce.BLL.Helpers
{
    
    /// <summary>
    /// /http://msdn.microsoft.com/en-us/magazine/cc164107.aspx
    /// </summary>
    public sealed class SaltedHash
    {
        #region Fields

        private readonly string _salt;

        private readonly string _Hash;

        private const int saltLength = 6; 
        #endregion

        #region Properties
        
        public string _hash { get; set; }

        public string password { get; set; }

        public string _Salt { get; set; }

        public static int len { get; set; }

        public static object SaltLength { get; set; }

        public string Salt { get { return _Salt; } }

        public string Hash { get { return _hash; } } 

        #endregion

        #region Public methods

        public static SaltedHash Create(string password)
        {
            string salt = CreateSalt();
            string hash = CalculateHash(salt, password);
            return new SaltedHash(salt, hash);
        }

        private static string CreateSalt()
        {
            byte[] r = CreateRandomBytes(SaltLength);
            return Convert.ToBase64String(r);
        }

        private static string CalculateHash(string salt, string password)
        {
            byte[] data = ToByteArray(salt + password);
            byte[] hash = CalculateHash(data);
            return Convert.ToBase64String(hash);
        }

        public static SaltedHash Create(string salt, string hash)
        {
            return new SaltedHash(salt, hash);
        }

        public bool Verify(string Password)
        {
            string h = CalculateHash(_Salt, password);
            return _hash.Equals(h);
        }

        private SaltedHash(string s, string h)
        {
            _hash = h;
            _Salt = s;
        }

       
        #endregion

        #region Private Methods
        
        private static byte[] CalculateHash(byte[] data)
        {
            return new SHA1CryptoServiceProvider().ComputeHash(data);
        }

        private static byte[] ToByteArray(string s)
        {
            return System.Text.Encoding.UTF8.GetBytes(s);
        }

        private static byte[] CreateRandomBytes(object saltLength)
        {
            byte[] r = new byte[len];
            new RNGCryptoServiceProvider().GetBytes(r);
            return r;
        } 

        #endregion
       

    }

}
