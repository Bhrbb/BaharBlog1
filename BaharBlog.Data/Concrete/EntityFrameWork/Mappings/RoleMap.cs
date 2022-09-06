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
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);//PrimaryKey
            builder.Property(r => r.Id).ValueGeneratedOnAdd();//birer birer art
            builder.Property(r => r.Name).HasMaxLength(30);
            builder.Property(r=>r.Description).IsRequired();
            builder.Property(r=>r.Name).IsRequired();//zorunlu alan
            builder.Property(r => r.Description).HasMaxLength(250);
            builder.Property(r => r.CreatedByName).IsRequired(true);
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedDate).HasMaxLength(50);
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.Property(r => r.CreatedDate).IsRequired(true);
            builder.Property(r => r.IsActive).IsRequired(true);
            builder.Property(r => r.IsDeleted).IsRequired(true);
            builder.ToTable("Roles");
            //tam veri tabanı olusurken yaptıgımz için ilk verileri elle dolduruyoruz
            builder.HasData(new Role
            {
                Id = 1,
                Name = "Admin",
                Description = "Admin bütün haklara sahiptir.",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "İnitialCreate",//veritabanı olusurken entityi veritabanı eklıyor
                ModifiedByName ="İnitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedDate = DateTime.Now

            });
        }
    }
}
