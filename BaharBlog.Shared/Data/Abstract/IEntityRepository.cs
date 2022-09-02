using BaharBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaharBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        //veritabanı nesneleri 
        //newlenebilir yani bir interface falan gçndermemeli
        //class olmalı ama oda IEntityi base alsın 
        //asenkron kodlama 
        //t neyse ona göre şekil alır
        Task<T> GetAsync(Expression<Func<T,bool>>predicate
            ,params Expression<Func<T,object>>[] includeProperties);//var kullanici=repository.GetAsync(k=>k.Id==);
        //predicate yani filtre
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null//mesela butun makaleler
            , params Expression<Func<T, object>>[] includeProperties);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);






    }
}
