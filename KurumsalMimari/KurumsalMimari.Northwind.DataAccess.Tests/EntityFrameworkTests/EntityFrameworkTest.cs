using System;
using KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurumsalMimari.Northwind.DataAccess.Tests.EntityFrameworkTests
{
    [TestClass]
    public class EntityFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDAL productDAL = new EfProductDAL();
            var result = productDAL.GetList();

            Assert.AreEqual(78, result.Count);
        }
    }
}
