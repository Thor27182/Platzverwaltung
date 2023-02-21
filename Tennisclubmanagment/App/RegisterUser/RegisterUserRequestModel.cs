using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RegisterUser
{
    internal class RegisterUserRequestmodel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddelNames { get; set;  }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int HouseNo { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Iban { get; set;}
        
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
