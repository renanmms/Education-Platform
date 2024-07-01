
using EducationPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EducationPlatform.Infrastructure.Persistence.Configurations
{
    public class ModuleConfigurations : IEntityTypeConfiguration<Module>
    {
        public void Configure(EntityTypeBuilder<Module> builder)
        {
            builder.HasKey(m => m.Id);

            builder
                .HasMany(m => m.Classes)
                .WithOne(c => c.Module)
                .HasForeignKey(m => m.ModuleId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}