using KurumsalMimari.Core.DataAccess;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Abstract
{
    public interface IProductDAL: IEntityRepository<Product>
    {
    }
}
