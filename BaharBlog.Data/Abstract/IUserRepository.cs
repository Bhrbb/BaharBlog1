using BaharBlog.Entities.Concrete;
using BaharBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Data.Abstract
{
    public interface IUserRepository :IEntityRepository<User>
    {
    }
}
