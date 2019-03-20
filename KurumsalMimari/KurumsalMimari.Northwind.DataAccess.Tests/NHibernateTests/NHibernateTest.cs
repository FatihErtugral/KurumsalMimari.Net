using System;
using KurumsalMimari.Northwind.DataAccess.Concrete.NHibernate;
using KurumsalMimari.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurumsalMimari.Northwind.DataAccess.Tests.NHibernateTests
{
    [TestClass]
    public class NHibarnateTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            NhProductDAL productDAL = new NhProductDAL(new SqlServerHelper());
            var result = productDAL.GetList();

            Assert.AreEqual(78, result.Count);
        }
        [TestMethod]
        public void Get_all_with_parameter_returns_fşktered_products()
        {
            NhProductDAL productDAL = new NhProductDAL(new SqlServerHelper());
            var result = productDAL.GetList(p=> p.ProductName.Contains("ab"));

            Assert.AreEqual(4, result.Count);
        }
    }
}
