using ImpactaLawTech.ToDo.Domain.Entities;
using ImpactaLawTech.ToDo.Domain.Enumerators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImpactaLawTechToDo.Infra.Data.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           builder.HasKey(x => x.Id);
           builder.Property(x => x.Name).IsRequired();
           builder.Property(x => x.Email).IsRequired();
           builder.Property(x => x.Password).IsRequired();

            builder.HasData(
                new User(1, "ADMIN", "ADMIN", "123", UserTypeEnumerator.ADMIN, null)
                );
        }
    }
}
