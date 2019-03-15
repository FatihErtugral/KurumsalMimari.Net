using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.Entities;

namespace KurumsalMimari.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepository<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private DbContext _context;
        private IDbSet<TEntity> _entities;

        public EfQueryableRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Table
        {
            get
            {
                return this.Entities;
            }
        }

        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<TEntity>();
                }
                return _entities;
            }
        }
    }
}
