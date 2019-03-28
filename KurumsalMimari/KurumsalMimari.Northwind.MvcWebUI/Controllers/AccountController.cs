using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KurumsalMimari.Core.CrossCuttingConcerns.Security.Web;
using KurumsalMimari.Northwind.Business.Abstract;

namespace KurumsalMimari.Northwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Account
        // http://localhost:50601/account/login?username=fatih&password=12345
        public string Login(string userName, string password)
        {
            var user = _userService.GetByUserNameAndPassword(userName, password);
            if ( user != null)
            {
                AuthenticationHelper.CreateAuthCookie(
                new Guid(),
                user.UserName,
                user.Email,
                DateTime.Now.AddDays(15),
                _userService.GetUserRoles(user).Select(u => u.RoleName).ToArray(),
                false,
                user.FirstName,
                user.LastName);
                return "User is authenticated!";
            }
            return "User is Not authenticated!";
            //AuthenticationHelper.CreateAuthCookie(
            //    new Guid(),
            //    "fatihertugral",
            //    "fatihertugral89@gmail.com",
            //    DateTime.Now.AddDays(15),
            //    new[] { "Admin" }, 
            //    false,
            //    "Fatih",
            //    "Ertugral");
            //return "User is authenticated!";
        }
    }
}