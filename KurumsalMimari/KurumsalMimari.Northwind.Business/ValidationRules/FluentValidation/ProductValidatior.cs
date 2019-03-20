using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KurumsalMimari.Northwind.Entities.Concrete;

namespace KurumsalMimari.Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidatior: AbstractValidator<Product>
    {
        public ProductValidatior()
        {
            RuleFor(p => p.CategoryID).NotEmpty().WithMessage("Kendi Mesajını koyabilirsin");
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.ProductName).Length(2, 20);
            RuleFor(p => p.UnitPrice).GreaterThan(20).When(p =>p.CategoryID == 1);
            //RuleFor(p => p.ProductName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
