using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KurumsalMimari.Core.CrossCuttingConcerns.Security.Web;

namespace KurumsalMimari.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public string Login()
        {
            AuthenticationHelper.CreateAuthCookie(
                new Guid(),
                "fatihertugral",
                "fatihertugral89@gmail.com",
                DateTime.Now.AddDays(15),
                new[] { "Admin" }, 
                false,
                "Fatih",
                "Ertugral");
            return "User is authenticated!";
        }
    }
}