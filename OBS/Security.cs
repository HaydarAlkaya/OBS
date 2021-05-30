using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OBS
{
    public class Security
    {
        public string Guvenlik(string Password)
        {
            using (SHA256 sha256 = new SHA256CryptoServiceProvider())
            {
                string HashingPassword = Convert.ToBase64String(sha256.ComputeHash(Encoding.UTF8.GetBytes(Password)));
                HashingPassword = HashingPassword.ToLower();
                return HashingPassword;
            }
        }
    }
}

