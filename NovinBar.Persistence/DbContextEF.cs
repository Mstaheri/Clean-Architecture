using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Extensions.Msal;
using NovinBar.Domain.Entities.SendingShipments;
using NovinBar.Domain.Entities.Users;
using NovinBar.Domain.Entities.ValueObject;
using NovinBar.Domain.SendingShipments;
using NovinBar.Domain.Users;
using NovinBar.Persistence.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Persistence
{
    public class DbContextEF : DbContext
    {
        public DbContextEF(DbContextOptions<DbContextEF> Connection) : base(Connection)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<SendingShipment> SendingShipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SendingShipmentConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());


            base.OnModelCreating(modelBuilder);
        }
    }
}
