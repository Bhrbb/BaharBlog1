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
            builder.HasOne<Category>(a => a.Category).WithMany(c=>c.Articles).HasForeignKey(a=>a.CategoryId);//bire çok 
            //heer bir makalenin bir categorysi var ama her kategorinin birden çok makalesi olur
            //bir kategori olmalı => birden cok article olabilir bir categoride categoryID foreign 
            builder.ToTable("Articles");//tablonun adı
            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);



        }
    }
}
