using Nutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutrition.DataAccessLayer.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(b => b.FirstName).IsRequired()
                                      .HasMaxLength(100);

            Property(b => b.LastName).IsRequired()
                                     .HasMaxLength(100);

            Ignore(b => b.FullName);

            Property(b => b.BirthDate).IsRequired();

            Property(b => b.Gender).IsRequired();

            Property(b => b.Height).IsRequired();

            Property(b => b.Weight).IsRequired();

            Property(b => b.Email).IsRequired()
                                  .HasMaxLength(100);

            Property(b => b.Password).IsRequired()
                                     .HasMaxLength(32);

            Property(b => b.CreatedDate);

            Property(b => b.UpdatedDate);
        }

    }
}
