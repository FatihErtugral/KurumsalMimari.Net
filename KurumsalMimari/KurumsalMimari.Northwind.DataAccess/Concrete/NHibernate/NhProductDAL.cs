using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.DataAccess.NHibernate;
using KurumsalMimari.Northwind.DataAccess.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDAL : NhEntityRepositoryBase<Product>, IProductDAL
    {
        public NhProductDAL(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
        }
    }
}
