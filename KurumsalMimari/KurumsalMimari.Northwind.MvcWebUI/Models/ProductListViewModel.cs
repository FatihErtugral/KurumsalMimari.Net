using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
    }
}