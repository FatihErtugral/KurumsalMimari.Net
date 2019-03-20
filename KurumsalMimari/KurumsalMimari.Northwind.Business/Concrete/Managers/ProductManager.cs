using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public Product Add(Product product)
        {
            return _productDAL.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDAL.GetList();
        }

        public Product GetById(int id)
        {
            return _productDAL.Get(p => p.ProductID == id);
        }
    }
}
