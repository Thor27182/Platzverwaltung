using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Utility
{
    public class Hasher
    {
        private byte[] _salt;
        private byte[] _hash;

        private const int _saltSize = 16;
        private const int _hashSize = 32;

        private readonly HashAlgorithmName _algorithmus = HashAlgorithmName.SHA256;
        private const int _iterationNumber = 300000;


        private const char separator = ':';

        public Hasher() {
            this._salt = GenerateSalt();
        }

        public string Hash(string input) {
            this._hash = Rfc2898DeriveBytes.Pbkdf2(
                input,
                _salt,
                _iterationNumber,
                _algorithmus,
                _hashSize
            );

            return string.Join(
                separator,
                Convert.ToHexString(_hash),
                Convert.ToHexString(_salt),
                _iterationNumber,
                _algorithmus
            );
        }

        private byte[] GenerateSalt() {
            return RandomNumberGenerator.GetBytes(_saltSize);
        }

    }
}
