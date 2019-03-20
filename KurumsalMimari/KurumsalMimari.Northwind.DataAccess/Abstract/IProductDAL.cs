using System.Collections.Generic;
using KurumsalMimari.Core.DataAccess;
using KurumsalMimari.Northwind.Entities.ComplexTypes;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Abstract
{
    public interface IProductDAL: IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
