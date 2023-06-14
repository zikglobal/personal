using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Core.commons
{
    internal class PasswordHelper
    {
        public static string CreateHash(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);

            return Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: salt,
                prf: KeyDerivationPrf.HMACSHA256, iterationCount: 100000, numBytesRequested: 256 / 8));
        }

        public static bool CheckPasswordHash(string password, string passwordHash)
        {
            var hash = CreateHash(password);
            return hash == passwordHash;
        }
    }
}
