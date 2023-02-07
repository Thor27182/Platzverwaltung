using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    public class Tennisclub
    {
        List<Tennisplayer> Tennisplayers { get; set; }
        List<Tenniscourt> Tenniscourts { get; set; }

        public Tennisclub()
        {
            Tennisplayers = new List<Tennisplayer>();
            Tenniscourts = new List<Tenniscourt>();
        }

        public void AddTennisplayer(Tennisplayer tennisplayer)
        {
               
        }

        public bool hasTennisplayer(string username) => 
            Tennisplayers.Any(x => x.Username.Equals(username, StringComparison.CurrentCultureIgnoreCase));
    }
}
