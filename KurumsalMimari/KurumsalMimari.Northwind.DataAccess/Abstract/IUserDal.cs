using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Core.DataAccess;
using KurumsalMimari.Northwind.Entities.ComplexTypes;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<UserRoleItem> GetUserRoles(User user);
    }
}
