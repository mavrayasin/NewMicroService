using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;
using NewMicroService.Catalog.API.Features.Courses;
using System.Reflection.Emit;

namespace NewMicroService.Catalog.API.Repositories
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToCollection("courses");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedNever();
            builder.Property(c => c.Name).HasElementName("name").HasMaxLength(100);
            builder.Property(c => c.Description).HasElementName("description").HasMaxLength(1000);
            builder.Property(c => c.Created).HasElementName("created");
            builder.Property(c => c.UserId).HasElementName("userId");
            builder.Property(c => c.CategoryId).HasElementName("categoryId");
            builder.Property(c => c.Picture).HasElementName("picture");
            builder.Property(c => c.Price).HasElementName("price");
            builder.Ignore(c => c.Category);

            builder.OwnsOne(x => x.Feature, featureBuilder =>
            {
                featureBuilder.HasElementName("feature");
                featureBuilder.Property(f => f.Duration).HasElementName("duration");
                featureBuilder.Property(f => f.Rating).HasElementName("rating");
                featureBuilder.Property(f => f.EducatorFullName).HasElementName("educatorFullName").HasMaxLength(200);
            });
        }
    }
}
