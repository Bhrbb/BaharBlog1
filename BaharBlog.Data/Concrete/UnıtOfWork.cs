using BaharBlog.Data.Abstract;
using BaharBlog.Data.Concrete.Context;
using BaharBlog.Data.Concrete.EntityFrameWork.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Data.Concrete
{
    public class UnıtOfWork : IUnitOfWork
    {
        private readonly BaharBlogContext _context;
        private EfArticleRepository _articleRepository;
        private EfCategoryRepository _categoryRepository;
        private EfCommentRepository _commentRepository;
        private EfUserRepository _userRepository;
        private EfRoleRepository _roleRepository;

        public UnıtOfWork(BaharBlogContext context)//dependcy injection
        {
            _context = context;
        }
        public IArticleRepository Articles => _articleRepository ?? new EfArticleRepository(_context);
        //Birisi IArtcileRepostıiryden artcles a ulastıgında eğer elimizde article varsas kullan yoksa newle 

        public ICategoryRepository Categorys => _categoryRepository ?? new EfCategoryRepository(_context);
        
        public ICommentRepository Comments => _commentRepository ?? new EfCommentRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        //dbinitialtior startupcs de oluyor proje baslayınca oluyıor
        //fluentAPi da direk veritabanı olusurken kuralları işler 
        //
    }
}
