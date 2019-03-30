using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Business.DependecyResolvers.Ninject;
using KurumsalMimari.Northwind.Business.ServiceContract.Wcf;
using KurumsalMimari.Northwind.Entities.Concrete;

/// <summary>
/// ProductDetailService için özet açıklama
/// </summary>
public class ProductDetailService : IProductDetailService
{
    private IProductService _productDetailService = InstanceFactory.GetInstance<IProductService>();

    public List<Product> GetAll()
    {
        return _productDetailService.GetAll();
    }
}