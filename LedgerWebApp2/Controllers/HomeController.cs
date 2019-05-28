using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LedgerWebApp2.Models;
using LedgerWebApp.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using LedgerApp;

namespace LedgerWebApp2.Controllers
{
    public class HomeController : Controller
    {

        private Dictionary<String, Account> accountDict = new Dictionary<String, Account>();


        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(CreateAccountModel model)
        {
            // TODO do work
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            if (LoginUser(loginModel.username, loginModel.password))
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.username)
            };

                var userIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                //This is not the best solution
                //Recore the current users username as a cookie
                Response.Cookies.Append("user", loginModel.username);

                //Just redirect to our index after logging in.
                return Redirect("/");
            }
            return View();
        }

        [Authorize]
        public IActionResult Index()
        {
            // TODO add functonality for deposit, withdrawal, check balance, and list transactions.
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool LoginUser(string username, string password)
        {
            //As an example. This method would go to our data store and validate that the combination is correct. 
            //For now just return true. 
            return true;
        }
    }
}
