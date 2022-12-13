using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    internal class Tenniscourt
    {
        int Courtnumber { get; set; }
        List<Reservation> Reservations { get; }

        public Tenniscourt(int courtnumber)
        {
            Courtnumber = courtnumber;
            Reservations = new List<Reservation>();
        }

        public void AddReservations(Reservation reservation)
        {
            Reservations.Add(reservation);
        }

        public void RemoveReservation(Reservation reservation)
        {
            Reservations.Remove(reservation);
        }
    }
}
