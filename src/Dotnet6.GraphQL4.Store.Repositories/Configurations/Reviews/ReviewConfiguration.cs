using Dotnet6.GraphQL4.Store.Domain.Entities.Reviews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet6.GraphQL4.Store.Repositories.Configurations.Reviews
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Comment)
                .IsUnicode(false)
                .HasMaxLength(1000);

            builder
                .Property(x => x.Title)
                .IsUnicode(false)
                .HasMaxLength(100);

            builder
                .HasOne(x => x.Product)
                .WithMany(x => x.Reviews);
        }
    }
}