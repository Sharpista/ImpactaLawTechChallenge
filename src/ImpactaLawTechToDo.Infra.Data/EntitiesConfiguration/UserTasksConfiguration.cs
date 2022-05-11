using ImpactaLawTech.ToDo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ImpactaLawTechToDo.Infra.Data.EntitiesConfiguration
{
    public class UserTasksConfiguration : IEntityTypeConfiguration<UserTasks>
    {
        public void Configure(EntityTypeBuilder<UserTasks> builder)
        {
           builder.HasKey(t => t.Id);
        }
    }
}
