using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectExamenCSHARP
{
    internal class DBGestion : DbContext
    {
        internal User user;

        public DbSet<User> Users { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Cour> Cours { get; set; }

        public DbSet<Emargement> Emargements { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        public DBGestion() : base("Connection")
        {
        }
    }
}
