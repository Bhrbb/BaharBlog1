using BaharBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Entities.Concrete
{
    public class Article:EntityBase,IEntity
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
       
        public int CommentsCount { get; set; }
        //Seo kısmı
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }//google kucuk kısmını göndermek için
        public string SeoTags { get; set; }//Anahtar kelimeler
        public int CategoryId { get; set; }
        public Category Category { get; set; }//category ulasıp onun ismini,acıklamasını almak
        public int UserId { get; set; }
        public User User { get; set; }
       
        public ICollection<Comment> Comments{ get; set; }//bir makale birden cok yoruma sahp olabilir




    }
}
