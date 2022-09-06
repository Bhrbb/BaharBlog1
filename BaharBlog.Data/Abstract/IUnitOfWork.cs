using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Data.Abstract
{
    public interface IUnitOfWork:IAsyncDisposable
    {
        IArticleRepository Articles { get; }//UnitofWorrk.Articles
        ICategoryRepository Categorys { get; }
        ICommentRepository Comments { get; }
        IRoleRepository Roles { get; }
        IUserRepository Users { get; }//_unitofwwork.Category.AddSync();
        //transaction işlemi yapmaya yarıyor yarıda hata verilirse işlem yapılmııyor 


        Task<int> SaveAsync();





    }
}
