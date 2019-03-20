using KurumsalMimari.Core.DataAccess.EntityFramework;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDAL :EfEntityRepositoryBase<Product, NorthwindContext>, IProductDAL
    {
       
    }
}
