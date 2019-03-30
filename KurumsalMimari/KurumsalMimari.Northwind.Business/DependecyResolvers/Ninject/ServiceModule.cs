using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.Utilities.Common;
using KurumsalMimari.Northwind.Business.Abstract;
using Ninject.Modules;

namespace KurumsalMimari.Northwind.Business.DependecyResolvers.Ninject
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().ToConstant(WcfProxy<IProductService>.CreateChannel());
        }
    }
}
