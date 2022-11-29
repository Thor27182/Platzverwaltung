using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Login
{
    internal class Login
    {

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
        
        }

        private string GetSalt() {
            return "Qtd62";
        }

        private string AddSalt(string password) {
            return password + GetSalt();
        }

    }
}
