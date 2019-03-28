using System.Collections.Generic;
using KurumsalMimari.Core.Aspects.PostsSharp.ValidationAspects;
using KurumsalMimari.Core.Aspects.PostsSharp.CacheAspects;
using KurumsalMimari.Core.Aspects.PostsSharp.TransactionAspects;
using KurumsalMimari.Core.CrossCuttingConcerns.Caching.Microsoft;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Business.ValidationRules.FluentValidation;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;
using KurumsalMimari.Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using KurumsalMimari.Core.Aspects.PostsSharp.LogAspects;
using KurumsalMimari.Core.Aspects.PostsSharp.PerformanceAspects;
using System.Threading;
using KurumsalMimari.Core.Aspects.PostsSharp.AuthorizationAspects;

namespace KurumsalMimari.Northwind.Business.Concrete.Managers
{
    //[LogAspect(typeof(FileLogger))] // Buraya yazarsak Class'ımızdaki bütün metotlar loglanıcaktır.
    public class ProductManager : IProductService
    {
        private IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        //[LogAspect(typeof(FileLogger))]
        public Product Add(Product product)
        {
            //ValidatorTool.FluentValidate(new ProductValidatior(), product);
            return _productDAL.Add(product);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [PerformanceCounterAspect(2)]
        [SecuredOperationAspect(Roles="Admin")]
        //[LogAspect(typeof(DatabaseLogger))]
        //[LogAspect(typeof(FileLogger))]
        public List<Product> GetAll()
        {
            Thread.Sleep(3000);
            return _productDAL.GetList();
        }

        
        public Product GetById(int id)
        {
            return _productDAL.Get(p => p.ProductID == id);
        }
        
        [TransactionScopeAspect]
        [FluentValidationAspect(typeof(ProductValidatior))]
        public void TransactionalOperation(Product product1, Product product2)
        {
            _productDAL.Add(product1);
            //
            _productDAL.Update(product2);
        }

        [FluentValidationAspect(typeof(ProductValidatior))]
        public Product Update(Product product)
        {
            return _productDAL.Update(product);
        }
    }
}
