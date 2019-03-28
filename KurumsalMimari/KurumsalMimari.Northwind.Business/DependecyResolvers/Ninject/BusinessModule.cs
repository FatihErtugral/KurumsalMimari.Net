using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.DataAccess;
using KurumsalMimari.Core.DataAccess.EntityFramework;
using KurumsalMimari.Core.DataAccess.NHibernate;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Business.Concrete.Managers;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework;
using KurumsalMimari.Northwind.DataAccess.Concrete.NHibernate;
using KurumsalMimari.Northwind.DataAccess.Concrete.NHibernate.Helpers;
using Ninject.Modules;

namespace KurumsalMimari.Northwind.Business.DependecyResolvers.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDAL>().To<EfProductDAL>().InSingletonScope();

            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind(typeof(IQueryableRepository<>)).To(typeof(EfQueryableRepository<>));
            Bind<DbContext>().To<NorthwindContext>();
            Bind<NHibernateHelper>().To<SqlServerHelper>();
        }
    }
}
