using BaharBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Data.Concrete.EntityFrameWork.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c=>c.Id);//primaryKey
            builder.Property(c => c.Id).ValueGeneratedOnAdd();//birbirekle 
            builder.Property(c=>c.Name).IsRequired(true);
            builder.Property(c => c.Name).HasMaxLength(70);
            builder.Property(c => c.Description).IsRequired(true);
            builder.Property(c => c.CreatedByName).IsRequired(true);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedDate).HasMaxLength(50);
            builder.Property(c=>c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c=> c.IsDeleted).IsRequired(true);
           // builder.Property(c=>c.Note).Has
            builder.ToTable("Categories");
            builder.HasData(
                new Category
                {
                    Id = 1,
                    Name = "C#",
                    Description = "C# programlama dili ile ilgili bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now


                },
                new Category
                {
                    Id = 2,
                    Name = "C++",
                    Description = "C++ programlama dili ile ilgili bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now

                },
                new Category
                {
                    Id = 3,
                    Name = "Javascript",
                    Description = "JavaScript programlama dili ile ilgili bilgiler",
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now
                });


        }
    }
}
