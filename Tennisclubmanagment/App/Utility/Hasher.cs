using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Utility
{
    /// <summary>
    /// Klasse zum Hashen von Passwoertern
    /// </summary>
    public class Hasher
    {
        /// <summary>
        /// Methode zum Generieren eines Salts
        /// </summary>
        /// <returns>Byte-Array des Salts</returns>
        private byte[] GenerateSalt()
        {
            byte[] salt;
            // zufaelliges Salt erstellen
            //new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            RandomNumberGenerator.Create().GetBytes(salt = new byte[16]);
            return salt;
        }

        /// <summary>
        /// Methode zum Hashen einer Zeichzenkette mit einem Salt
        /// </summary>
        /// <param name="s">zu hashende Zeichenkette</param>
        /// <param name="salt">Salt als Byte-Array</param>
        /// <returns></returns>
        private byte[] GenerateHash(string s, byte[] salt) 
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(s, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);
            return hash;
        }

        /// <summary>
        /// Methode zum Kombinieren der Byte-Arrays des Hashes und des Salts
        /// </summary>
        /// <param name="hash">Byte-Array des Hashes</param>
        /// <param name="salt">Byte-Array des Salts</param>
        /// <returns></returns>
        private byte[] Combine(byte[] hash, byte[] salt)
        {
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            return hashBytes;
        }

        /// <summary>
        /// Methode zum Umwandeln des Byte-Arrays in eine Zeichenkette
        /// </summary>
        /// <param name="hashBytes">Byte-Array, welches umzuwandeln ist</param>
        /// <returns>Zeichenkette</returns>
        private string ConvertToString(byte[] hashBytes) {
            return Convert.ToBase64String(hashBytes);
        }

        /// <summary>
        /// Methode zum Hashen einer Zeichenkette
        /// </summary>
        /// <param name="s">zu hashende Zeichenkette</param>
        /// <returns>gehashte Zeichenkette</returns>
        public string Hash(string s) {
            // Salt erzeugen
            byte[] salt = GenerateSalt();
            // Zeichenkette mit dem Salt hashen
            byte[] hashBytes = GenerateHash(s, salt);
            // Salt und Hashwert kombinieren
            byte[] combined = Combine(hashBytes, salt);
            // kombiniertes Byte-Array in Zeichenkette umwandeln
            return ConvertToString(combined);

        }

    }
}
