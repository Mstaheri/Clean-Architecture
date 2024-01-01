using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.Extensions.Msal;
using NovinBar.Domain.Entities.SendingShipments;
using NovinBar.Domain.Entities.Users;
using NovinBar.Domain.Entities.ValueObject;
using NovinBar.Domain.SendingShipments;
using NovinBar.Domain.Users;
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
        public DbSet<User> User { get; set; }
        public DbSet<SendingShipment> SendingShipment { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SendingShipment>(option =>
            {
                option.HasKey(per => per.Barname);

                option.Property(per => per.SenderFirstName)
                .HasMaxLength(50)
                .IsUnicode(true);

                option.Property(per => per.SenderLastName)
                .HasMaxLength(50)
                .IsUnicode(true);

                option.Property(per => per.SenderPhoneNumber)
                .HasMaxLength(11)
                .IsUnicode(false);

                option.Property(per => per.ReceiverFirstName)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.ReceiverLastName)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.ReceiverPhoneNumber)
               .HasMaxLength(11)
               .IsUnicode(false);

                option.Property(per => per.OriginCity)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.OriginWarehouse)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.DestinationCity1)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.DestinationWarehouse1)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.DestinationCity2)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.DestinationWarehouse2)
               .HasMaxLength(50)
               .IsUnicode(true);

                option.Property(per => per.Date)
               .HasMaxLength(10)
               .IsUnicode(true);

                option.Property(per => per.Time)
               .HasMaxLength(5)
               .IsUnicode(true);

                option
                .HasMany(p => p.SendingCommodities)
                .WithOne()
                .HasForeignKey("Barname")
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired(true);

            });
            modelBuilder.Entity<User>(Option =>
            {
                Option.HasKey(p => p.UserName);
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
