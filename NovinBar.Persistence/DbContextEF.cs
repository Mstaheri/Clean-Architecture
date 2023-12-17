using NovinBar.Domain.Entities.Users;
using NovinBar.Domain.SendingShipments;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Persistence
{
    public class DbContextEF : DbContext
    {
        public DbContextEF(string Connection) : base(Connection)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<SendingShipment> SendingShipment { get; set; }
    }
}
