using App.Utility;
using Domainmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public class UserRepository
    {
        public void Add(Tennisplayer userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;

            // Hashen des Passwortes
            Hasher hasher = new Hasher();
            credential.Password = hasher.Hash(credential.Password);

            /*
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM user WHERE username = @username AND password = @password";
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = credential.UserName;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = credential.Password;
                validUser = command.ExecuteScalar() == null ? false : true;
            }*/

            // Wieder Rausnehmen, wenn das mit Verweis geklappt hat:
            validUser = true;

            return validUser;
        }

        public void Edit(Tennisplayer userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tennisplayer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tennisplayer GetById(int id)
        {
            throw new NotImplementedException();
        }

        // TODO: Verweis hinzufuegen, damit alles MySQL-Spezifisches klappt

        public Tennisplayer GetByUsername(string username)
        {
            Tennisplayer user = null;
            /*
            using (var connection = GetConnection())
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = $"SELECT * FROM user WHERE username = @username";
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        //TODO: Werte in UserModell (Tennissplayer) packen

                        // reader[SpaltenNummer].ToString()
                        // string.Empty - bei Password
                        // 
                        //user = new Tennisplayer(wert1,wert2,...);
                    }
                }

            }*/

            // Wieder Rausnehmen, wenn das mit Verweis geklappt hat:
            user = new Tennisplayer("DummyName", "", "First", "Last", "", "Streetname", 12, "00000", "Stadt", "IBAN");

            return user;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
