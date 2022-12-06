using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Login
{
    internal class Login
    {

        public static bool DoLogin(string username, string hashedPassword) {
            // Nur Rückgabe, wenn Username und gehashted Passwort passen
            string sql = "SELECT * FROM users WHERE username = '" + username + "' AND password = '" + hashedPassword + "';";

            // TODO: DB anbindung auslagern
            MySqlConnection conn = new MySqlConnection();
            // TODO: einbauen

            bool found = true;

            return found;
        }

        /*
        public bool DoLogin(string user, string password) {

            // Salt anhaengen
            password = AddSalt(password);


            // Passwort Hashen
            // https://crackstation.net/hashing-security.htm
            // https://www.experte.de/it-sicherheit/passwort-hashing
            // https://dev.to/1001binary/hashing-password-combining-with-salt-in-c-and-vb-net-2am9
            // https://www.codeproject.com/Articles/1104467/Hashing-Passwords-in-NET-Core-with-Tips

            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm?view=net-7.0

            // In DB suchen

            // Bei Uebereinstimmung true zurueckgeben

            // Sonst false

            return false;
        
        }*/

        /*
        private string GetSalt() {
            return "Qtd62";
        }

        private string AddSalt(string password) {
            return password + GetSalt();
        }*/

    }
}
