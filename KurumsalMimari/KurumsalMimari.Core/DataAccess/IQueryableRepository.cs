using System.Linq;
using KurumsalMimari.Core.Entities;

namespace KurumsalMimari.Core.DataAccess
{
    public interface IQueryableRepository<T> where T:class, IEntity, new()
    {
        IQueryable<T> Table { get;  }
    }
}
