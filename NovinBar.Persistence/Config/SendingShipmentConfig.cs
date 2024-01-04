using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NovinBar.Domain.SendingShipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Persistence.Config
{
    public class SendingShipmentConfig : IEntityTypeConfiguration<SendingShipment>
    {
        public void Configure(EntityTypeBuilder<SendingShipment> option)
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

            option.Property<DateTime>("InsertDate");
            option.Property<DateTime>("UpdateDate");

            option
            .HasMany(p => p.SendingCommodities)
            .WithOne()
            .HasForeignKey(p => p.Barname)
            .OnDelete(DeleteBehavior.Cascade)
            .IsRequired(true);

            
            
        }
    }
}
