using System;
using FluentValidation;
using KurumsalMimari.Northwind.Business.Concrete.Managers;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace KurumsalMimari.Northwind.Business.Tests
{
    [TestClass]
    public class ProductManagerTests
    {
        [ExpectedException(typeof(ValidationException))]
        [TestMethod]
        public void Product_validation_check()
        {
            Mock<IProductDAL> mock = new Mock<IProductDAL>();
            //ProductManager productManager = new ProductManager(mock.Object);

            //productManager.Add(new Product());
        }
    }
}
