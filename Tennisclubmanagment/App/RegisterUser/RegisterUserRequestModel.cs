using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RegisterUser
{
    internal class RegisterUserRequestmodel
    {
        public string Username { get; }
        public string Password { get; }
        public string FirstName { get; }
        public string MiddelNames { get; }
        public string LastName { get; }
        public string Street { get; }
        public int HouseNo { get; }
        public string PostCode { get; }
        public string Iban { get; }
        
        public RegisterUserRequestmodel(
           string username,
           string password,
           string firstName,
           string middelNames,
           string lastName,
           string street,
           int houseNo,
           string postCode,
           string city,
           string iban)
        {
            Username = username;
            Password = password;
            FirstName = firstName;
            MiddelNames = middelNames;
            LastName = lastName;
            Street = street;
            HouseNo = houseNo;
            PostCode = postCode;
            City = city;
            Iban = iban;
        }


    }
}
