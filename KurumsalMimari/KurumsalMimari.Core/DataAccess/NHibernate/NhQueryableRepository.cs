using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.Entities;

namespace KurumsalMimari.Core.DataAccess.NHibernate
{
    class NhQueryableRepository<TEntity> : IQueryableRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        IQueryable<TEntity> _entities;

        public NhQueryableRepository(NHibernateHelper nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }
        public IQueryable<TEntity> Table => this.Entities;

        public virtual IQueryable<TEntity> Entities
        {
            get
            {
                if(_entities == null)
                {
                    _entities = _nHibernateHelper.OpenSession().Query<TEntity>();
                }
                return _entities;
            }
        }
    }
}
