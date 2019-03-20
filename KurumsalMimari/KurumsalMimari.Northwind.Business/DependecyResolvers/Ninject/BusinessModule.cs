using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Business.Concrete.Managers;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace KurumsalMimari.Northwind.Business.DependecyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDAL>().To<EfProductDAL>();
        }
    }
}
