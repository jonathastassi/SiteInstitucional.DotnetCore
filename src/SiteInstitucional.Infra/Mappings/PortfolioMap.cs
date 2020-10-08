using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SiteInstitucional.Domain;

namespace SiteInstitucional.Infra
{
    public class PortfolioMap : IEntityTypeConfiguration<Portfolio>
    {
        public void Configure(EntityTypeBuilder<Portfolio> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Visible)
                .IsRequired()
                .HasColumnType("INTEGER")
                .HasDefaultValue(0);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasColumnType("TEXT");

            builder.Property(c => c.Image)
                .IsRequired()
                .HasColumnType("TEXT");

            builder.Property(c => c.CreatedAt)
                .IsRequired()
                .HasColumnType("TEXT");

            builder.ToTable("PORTFOLIOS");
        }
    }
}
