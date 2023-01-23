using Domainmodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App.UserRepository
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(Tennisplayer user);
        void Edit(Tennisplayer user);
        void Remove(int id);
        Tennisplayer GetById(int id);
        Tennisplayer GetByUsername(string username);
        IEnumerable<Tennisplayer> GetAll();
    }
}
