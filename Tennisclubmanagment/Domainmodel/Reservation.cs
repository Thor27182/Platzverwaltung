using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    public class Reservation
    {
        public Tenniscourt Tenniscourt { get; set; }
        public Tennisplayer Tennisplayer { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Reservation(Tenniscourt tenniscourt, Tennisplayer tennisplayer, DateTime start, DateTime end)
        {
            Tenniscourt = tenniscourt;
            Tennisplayer = tennisplayer;
            Start = start;
            End = end;
        }
    }
}
