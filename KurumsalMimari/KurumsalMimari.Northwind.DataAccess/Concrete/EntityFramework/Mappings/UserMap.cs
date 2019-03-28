using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable(@"Users", @"dbo");
            HasKey(x => x.Id);

            Property(x => x.UserName).HasColumnName("UserName");
            Property(x => x.LastName).HasColumnName("LastName");
            Property(x => x.FirstName).HasColumnName("FirstName");
            Property(x => x.Password).HasColumnName("Password");
            Property(x => x.Email).HasColumnName("Email");
        }
    }
}
