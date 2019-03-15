using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using KurumsalMimari.Core.Entities;

namespace KurumsalMimari.Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T,bool>> filter = null);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
    }
}
