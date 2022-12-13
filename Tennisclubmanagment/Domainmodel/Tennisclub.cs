using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    internal class Tennisclub
    {
        List<Tennisplayer> Tennisplayers { get; set; }
        List<Tenniscourt> Tenniscourts { get; set; }

        public Tennisclub()
        {
            Tennisplayers = new List<Tennisplayer>();
            Tenniscourts = new List<Tenniscourt>();
        }
    }
}
