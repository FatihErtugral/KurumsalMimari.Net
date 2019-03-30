using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Business.Concrete.Managers;
using KurumsalMimari.Northwind.Business.DependecyResolvers.Ninject;
using KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework;
using KurumsalMimari.Northwind.Entities.Concrete;

/// <summary>
/// ProductService için özet açıklama
/// </summary>
public class ProductService : IProductService
{
    public ProductService()
    {
        //
        //TODO: Buraya oluşturucu mantığı ekleyin
        //
    }

    IProductService _productService = InstanceFactory.GetInstance<IProductService>();

    public Product Add(Product product)
    {
        return _productService.Add(product);
    }

    public List<Product> GetAll()
    {
        return _productService.GetAll();
    }

    public Product GetById(int id)
    {
        return _productService.GetById(id);
    }

    public void TransactionalOperation(Product product1, Product product2)
    {
        _productService.TransactionalOperation(product1, product2);
    }

    public Product Update(Product product)
    {
        return _productService.Update(product);
    }
}