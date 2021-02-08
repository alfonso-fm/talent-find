using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
  public class CompanyConfiguration : IEntityTypeConfiguration<Company>
  {
    public void Configure(EntityTypeBuilder<Company> builder)
    {
      builder.Property(p => p.Id).IsRequired();
      builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
      builder.Property(p => p.BusinessName).IsRequired().HasMaxLength(500);
      builder.HasOne(t => t.CompanyType).WithMany().HasForeignKey(p => p.CompanyTypeId);
      builder.HasOne(s => s.CompanySize).WithMany().HasForeignKey(p => p.CompanySizeId);
    }
  }
}