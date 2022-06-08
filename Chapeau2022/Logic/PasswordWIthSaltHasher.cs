using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace Logic
{
    public class PasswordWithSaltHasher
    {
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }
        public HashWithSaltResult HashWithGivenSalt(string password, string salt, HashAlgorithm hashAlgo)
        {

            byte[] saltBytes = Convert.FromBase64String(salt);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            string saltNew = Convert.ToBase64String(saltBytes);
            string digestNew = Convert.ToBase64String(digestBytes);
            return new HashWithSaltResult(saltNew, digestNew);
        }
        public static bool IsPasswordCorrect(string password, HashWithSaltResult hashResult)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();

            HashWithSaltResult hashResultSha512 = pwHasher.HashWithGivenSalt(password, hashResult.Salt, SHA512.Create());
            if (hashResultSha512.Digest == hashResult.Digest)
            {
                return true;
            }
            return false;

        }
        public static HashWithSaltResult HashPasswordWithSalt(string password)
        {
            PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashResultSha512 = pwHasher.HashWithSalt(password, 64, SHA512.Create());

            return hashResultSha512;
        }
    }
}