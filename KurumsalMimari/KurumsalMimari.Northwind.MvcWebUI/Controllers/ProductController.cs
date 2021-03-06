﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KurumsalMimari.Northwind.Business.Abstract;
using KurumsalMimari.Northwind.Entities.Concrete;
using KurumsalMimari.Northwind.MvcWebUI.Models;

namespace KurumsalMimari.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index()
        {
            var model = new ProductListViewModel
            {
                Products = _productService.GetAll()
            };
            return View(model);
        }

        public string Add()
        {
            _productService.Add(new Product
            {
                CategoryID = 1,
                ProductName = "GSM",
                QuantityPerUnit = "1",
                UnitPrice = 21
            });
            return "Added";
            //localhost:xxxx/Product/Add
        }

        public string AddUpdate() //Transaction Scope Aspect Testi
        {
            _productService.TransactionalOperation(new Product
            {
                CategoryID = 1,
                ProductName = "Computer1",
                QuantityPerUnit = "1",
                UnitPrice = 24
            },new Product
            {
                CategoryID = 1,
                ProductName = "Computer2",
                QuantityPerUnit = "1",
                UnitPrice = 30,// Bu değeri 20 nin altında yaparsak bir hata fırlatıcak ve önceki kaydı geri silecektir.
                ProductID = 2
            });

            return "Done";
        }
    }
}