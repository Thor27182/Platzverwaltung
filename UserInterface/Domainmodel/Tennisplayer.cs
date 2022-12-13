using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    internal class Tennisplayer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string? MiddelNames { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int HouseNo { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public string Iban { get; set; }
        List<Reservation> Reservations { get; }

        public Tennisplayer(
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
            Postcode = postCode;
            City = city;
            Iban = iban;
            Reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            Reservations.Add(reservation);
        }

        public void RemoveReservation(Reservation reservation)
        {
            Reservations.Remove(reservation);
        }
    }
}
