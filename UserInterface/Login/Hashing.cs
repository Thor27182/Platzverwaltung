using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Login
{
    public class Hashing {

        /// <summary>
        /// Methode zum Hashen einer Zeichenkette mit Salt
        /// </summary>
        /// <param name="text">Zeichenkette, die gehasht werden soll</param>
        /// <returns>gehashte Zeichenkette</returns>
        public static string DoHash(string text) {
            // Salt hinzufuegen
            string salted = AddSalt(text);

            HashAlgorithm sha = SHA256.Create();
            // Hashen
            byte[] hashed = sha.ComputeHash(Encoding.UTF8.GetBytes(salted)); ;

            // gehashte Zeichenkette zurueckgeben
            return hashed.ToString();
        }

        /// <summary>
        /// Methode zum Salt hinzufuegen
        /// </summary>
        /// <param name="text">Zeichenkette, der ein Salt hinzugefuegt werden soll</param>
        /// <returns>Zeichenkette mit angehaengtem Salt</returns>
        private static string AddSalt(string text) {
            string salt = "Qtd62";
            string salted = text + salt;
            return salted;
        }
    }
}
