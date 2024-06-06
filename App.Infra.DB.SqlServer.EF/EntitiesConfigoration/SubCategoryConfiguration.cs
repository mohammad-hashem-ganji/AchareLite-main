using App.Domain.Core.CategoryService.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Infra.DB.SqlServer.EF.EntitiesConfigoration
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(40);
            #region seed data
            builder.HasData(new SubCategory { Id = 1, Title ="نظافت و پذیرایی", MainCategoryId = 1 });
            builder.HasData(new SubCategory { Id = 1, Title ="شستشو", MainCategoryId = 1 });
            builder.HasData(new SubCategory { Id = 1, Title ="سرمایش و گرمایش", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="تعمیرات ساختمان", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="لوله کشی", MainCategoryId = 2});
            builder.HasData(new SubCategory { Id = 1, Title ="طراحی و بازسازی ساختمان", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="برقکاری", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="چوب و کابینت", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="باغبانی و فضای سبز", MainCategoryId = 2 });
            builder.HasData(new SubCategory { Id = 1, Title ="نصب و تعمیر لوازم خانگی", MainCategoryId = 3 });
            builder.HasData(new SubCategory { Id = 1, Title ="خدمات کامپیوتری", MainCategoryId = 3 });
            builder.HasData(new SubCategory { Id = 1, Title ="تعمیرات موبایل", MainCategoryId = 3 });
            builder.HasData(new SubCategory { Id = 1, Title ="باربری و جابجایی", MainCategoryId = 4 });
            builder.HasData(new SubCategory { Id = 1, Title ="خدمات و تعمیرات خودرو", MainCategoryId = 5 });
            builder.HasData(new SubCategory { Id = 1, Title ="کارواش و دیتیلینگ", MainCategoryId = 5 });
            builder.HasData(new SubCategory { Id = 1, Title ="زیبایی بانوان", MainCategoryId = 6 });
            builder.HasData(new SubCategory { Id = 1, Title ="پزشکی و پرستاری", MainCategoryId = 6 });
            builder.HasData(new SubCategory { Id = 1, Title ="حیوانات خانگی", MainCategoryId = 6 });
            builder.HasData(new SubCategory { Id = 1, Title ="پیرایش و زیبایی آقایان", MainCategoryId = 6 });
            builder.HasData(new SubCategory { Id = 1, Title ="تندرستی و ورزش", MainCategoryId = 6 });

            #endregion
        }
    }
}