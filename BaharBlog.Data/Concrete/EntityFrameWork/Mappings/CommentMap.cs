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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();//birer birer artması
            builder.Property(c=>c.Text).IsRequired();//zorunlu boş geçilemez
            builder.Property(c=>c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c=>c.Article).WithMany(a=>a.Comments).HasForeignKey(c=>c.ArticleId);//bir article birden fazlla yorum olabilir 
            builder.Property(c => c.CreatedByName).IsRequired(true);
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedDate).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.CreatedDate).IsRequired(true);
            builder.Property(c => c.IsActive).IsRequired(true);
            builder.Property(c => c.IsDeleted).IsRequired(true);
            builder.ToTable("Comments");
            builder.HasData(new Comment
            {
                Id = 1,
                IsDeleted = false,
                ArticleId = 1,
                IsActive = true,
                Text = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi,",
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now

            },
            new Comment
            {
                Id = 2,
                IsDeleted = false,
                ArticleId = 2,
                IsActive = true,
                Text = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi,",
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now


            }, new Comment
            {
                Id = 3,
                IsDeleted = false,
                ArticleId = 3,
                IsActive = true,
                Text = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi,",
                ModifiedByName = "InitialCreate",
                ModifiedDate = DateTime.Now,
                CreatedByName = "InitialCreate",
                CreatedDate = DateTime.Now

            });
        }
    }
}
