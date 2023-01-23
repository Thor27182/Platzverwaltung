using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;

        public RepositoryBase() {
            _connectionString = $"server={Resource1.HOST};user={Resource1.USER};database={Resource1.DATABASE};port={Resource1.PORT};password={Resource1.PASSWORD}";
        }

        // TODO: Verweis hinzufuegen, damit alles MySQL-Spezifisches klappt
        /*
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(GetConnectionString());
        }*/
    }
}
