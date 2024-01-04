using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NovinBar.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovinBar.Persistence.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.UserName);

            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(p => p.PassWord)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(11)
                .IsUnicode(false);
        }
    }
}
