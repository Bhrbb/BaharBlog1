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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u=>u.Id).ValueGeneratedOnAdd();
            builder.Property(u=>u.Email).IsRequired();
            builder.Property(u=>u.Email).HasMaxLength(50);
            builder.HasIndex(u=>u.Email).IsUnique();//uniqe mi diye bakar aynısından bır daha kayıtı onler 
            builder.HasIndex(u=>u.UserNAme).IsUnique();
            builder.Property(u=>u.UserNAme).IsRequired();
            builder.Property(u=>u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");
            builder.Property(u => u.Description).HasMaxLength(500);
            builder.Property(u=>u.FirstName).IsRequired();
            builder.Property(u=>u.LastName).IsRequired();
            builder.Property(u=>u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);
            builder.HasOne(u => u.Role).WithMany(u => u.Users).HasForeignKey(u => u.Role);
            //bir role birden fazla kullanıcıya olabilir
            builder.Property(u =>u.CreatedByName).IsRequired(true);
            builder.Property(u =>u.CreatedByName).HasMaxLength(50);
            builder.Property(u =>u.ModifiedDate).HasMaxLength(50);
            builder.Property(u =>u.ModifiedByName).HasMaxLength(50);
            builder.Property(u =>u.CreatedDate).IsRequired(true);
            builder.Property(u =>u.IsActive).IsRequired(true);
            builder.Property(u =>u.IsDeleted).IsRequired(true);
            builder.ToTable("Users");
            builder.HasData(new User
            {
                Id = 1,
                RoleId = 1,
                FirstName = "Bahar",
                LastName = "Pehlivan",
                UserNAme = "bhrbb",
                Email = "bhrbzdmr@gmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now,
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                Description = "İlk Kullanıcı",
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU",
                PasswordHash = Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500")
            }) ;


        }
    }
}
