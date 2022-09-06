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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
           builder.HasKey(a=>a.Id);//primaryKey yaptık
           builder.Property(a=>a.Id).ValueGeneratedOnAdd();//bir bir arttır ekle
            builder.Property(a => a.Title).HasMaxLength(100);//max uzunlugu
            builder.Property(a=>a.Title).IsRequired(true);//başlık zorunlu boş geçilemez
            builder.Property(a=>a.Content).IsRequired(true);//içeriği boş geçilemez 
            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.SeoAuthor).HasMaxLength(50);
            builder.Property(a => a.SeoAuthor).IsRequired(true);
            builder.Property(a=>a.SeoDescription).HasMaxLength(50);
            builder.Property(a=>a.SeoDescription).IsRequired(true);
            builder.Property(a=>a.Date).IsRequired(true);
            builder.Property(a=>a.SeoTags).IsRequired(true);
            builder.Property(a=>a.ViewsCount).IsRequired(true);
            builder.Property(a=>a.CommentsCount).IsRequired(true);
            builder.Property(a=>a.Thumbnail).IsRequired(true);//Resim dolu olsun
            builder.Property(a=>a.Thumbnail).HasMaxLength(50);
            builder.Property(a=>a.CreatedByName).IsRequired(true);
            builder.Property(a=>a.CreatedByName).HasMaxLength(50);
            builder.Property(a=>a.ModifiedDate).HasMaxLength(50);
            builder.Property(a=>a.CreatedDate).IsRequired(true);
            builder.Property(a=>a.IsActive).IsRequired(true);
            builder.Property(a=>a.IsDeleted).IsRequired(true);
            //builder.Property(a => a.Note).HasMaxLength(500);
            builder.HasOne<Category>(a => a.Category).WithMany(c=>c.Articles).HasForeignKey(a=>a.CategoryId);//bire çok 
            //heer bir makalenin bir categorysi var ama her kategorinin birden çok makalesi olur
            //bir kategori olmalı => birden cok article olabilir bir categoride categoryID foreign 
            builder.ToTable("Articles");//tablonun adı
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "c# 9.0 .net 5 Yenilikleri",
                    Content = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi.",
                    Thumbnail = "default.jpeg",
                    SeoDescription = "c# 9.0 .net 5 Yenilikleri",
                    SeoTags = "c#,.Net,.NetFramework",
                    SeoAuthor = "Bahar Pehlivan",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    ModifiedByName = "InitialCreate",
                    UserId = 1,
                    ModifiedDate = DateTime.Now,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ViewsCount=100,
                    CommentsCount=1

                },
                 new Article
                 {
                     Id = 2,
                     CategoryId = 2,
                     Title = "c++ 11.0 Yenilikleri",
                     Content = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi.",
                     Thumbnail = "default.jpeg",
                     SeoDescription = "c++ 11.0 Yenilikleri",
                     SeoTags = "c++,.Net,.NetFramework",
                     SeoAuthor = "Bahar Pehlivan",
                     Date = DateTime.Now,
                     IsActive = true,
                     IsDeleted = false,
                     ModifiedByName = "InitialCreate",
                     UserId = 1,
                     ModifiedDate = DateTime.Now,
                     CreatedByName = "InitialCreate",
                     CreatedDate = DateTime.Now,
                     ViewsCount = 150,
                     CommentsCount = 1
                 },
                  new Article
                  {
                      Id = 3,
                      CategoryId = 3,
                      Title = "Javascript s2019 Yenilikleri",
                      Content = "Lorem Ipsum , baskı ve dizgi endüstrisinin basit bir sahte metnidir. Lorem Ipsum, bilinmeyen bir matbaacının bir tip numune kitabı yapmak için bir yazı galerisini alıp karıştırdığı 1500'lerden beri endüstrinin standart sahte metni olmuştur. Sadece beş yüzyıl boyunca hayatta kalmayıp, aynı zamanda esasen değişmeden elektronik dizgiye sıçradı. 1960'larda Lorem Ipsum pasajları içeren Letraset sayfalarının yayınlanmasıyla ve daha yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümlerini içeren masaüstü yayıncılık yazılımlarıyla popüler hale geldi.",
                      Thumbnail = "default.jpeg",
                      SeoDescription = "c# 9.0 .net 5 Yenilikleri",
                      SeoTags = "javaScript,.Net,.NetFramework",
                      SeoAuthor = "Bahar Pehlivan",
                      Date = DateTime.Now,
                      IsActive = true,
                      IsDeleted = false,
                      ModifiedByName = "InitialCreate",
                      UserId = 1,
                      ModifiedDate = DateTime.Now,
                      CreatedByName = "InitialCreate",
                      CreatedDate = DateTime.Now,
                      ViewsCount = 10,
                      CommentsCount = 1
                  });



        }
    }
}
