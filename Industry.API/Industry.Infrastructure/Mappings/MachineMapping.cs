using Industry.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Industry.Infrastructure.Mappings
{
    public class MachineMapping : IEntityTypeConfiguration<Machine>
    {
        public void Configure(EntityTypeBuilder<Machine> builder)
        {
            builder.ToTable("Machine");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Manufacter)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Value)
                .HasColumnType("decimal(18,2)")
                .IsRequired();
        }
    }
}
