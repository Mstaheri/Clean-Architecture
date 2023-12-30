using Microsoft.EntityFrameworkCore;
using NovinBar.Domain.Entities.Users;
using NovinBar.Domain.SendingCommoditys;
using NovinBar.Domain.SendingShipments;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Persistence
{
    public class DbContextEF : DbContext
    {
        public DbContextEF(DbContextOptions<DbContextEF> Connection) : base(Connection)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<SendingShipment> SendingShipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SendingShipment>(option =>
            {
                option.Property(per => per.Barname)
                .HasMaxLength(50)
                .IsRequired();
                option.OwnsMany(per => per.SendingCommoditie, addOption=>
                {
                    addOption.Property(addr => addr.firstname)
                    .HasMaxLength(50);
                });
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
