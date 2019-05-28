using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LedgerWebApp2.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using LedgerApp;
using System.Globalization;
using System.Threading;

namespace LedgerWebApp2.Controllers
{
    public class HomeController : Controller
    {
        //This is not a great solution (Look into seesions)
        static private Dictionary<String, Account> accountDict = new Dictionary<String, Account>();

        [HttpGet]
        public IActionResult CheckBalance()
        {
            string username = Request.Cookies["user"];

            //Format output for balance if balance is negative.
            //Source: https://dzone.com/articles/display-and-format-negative
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo newCulture = new CultureInfo(currentCulture.Name);
            newCulture.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulture;

            ViewBag.Balance = String.Format("{0:C}", accountDict[username].checkBalance());
            // TODO get balance 
            return View();
        }

        [HttpGet]
        public IActionResult RecordDeposit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecordDeposit(RecordTransactionModel model)
        {
            string username = Request.Cookies["user"];
            System.Diagnostics.Debug.WriteLine(username);
            System.Diagnostics.Debug.WriteLine(accountDict.Keys.Count);

            accountDict[username].recordDeposit(model.Amount);
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult RecordWithdrawal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RecordWithdrawal(RecordTransactionModel model)
        {
            string username = Request.Cookies["user"];
            accountDict[username].recordWithdrawal(model.Amount);
            return Redirect("/");
        }

        [HttpGet]
        public IActionResult ViewHistory()
        {
            string username = Request.Cookies["user"];
            List<string> outputList = new List<string>();
            foreach(var t in accountDict[username].getTransactionHistory())
            {
                outputList.Add(String.Format("{0}: {1:C}", t.getOperation(), t.getAmount()));
            }
            ViewBag.TransactionHistory = outputList;
            return View();
        }

        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(CreateAccountModel model)
        {
            //Check that account doesn't already exist.
            if (accountDict.ContainsKey(model.username))
            {
                ViewBag.AccountCreationError = "I'm sorry, that username is already taken. Please choosen another.";
                return View();
            }

            //Create Account object with user input.
            Account acct = new Account(model.username, model.password, model.firstName, model.lastName);
            accountDict.Add(model.username, acct);
            System.Diagnostics.Debug.WriteLine(accountDict.Keys.Count);

            return Redirect("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            System.Diagnostics.Debug.WriteLine(accountDict.Keys.Count);

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
            ViewBag.LoginError = "Error. Your username and password combination is incorrect.";
            return View();
        }

        public IActionResult Logout()
        {
            string username = Request.Cookies["user"];

            accountDict[username].logOut();
            HttpContext.SignOutAsync();
            return Redirect("Login");
        }

        [Authorize]
        public IActionResult Index()
        {
            if (!Request.Cookies.ContainsKey("user"))
            {
                return Redirect("/Home/Login");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private bool LoginUser(string username, string password)
        {
            System.Diagnostics.Debug.WriteLine(accountDict.Keys.Count);

            if (!accountDict.ContainsKey(username))
            {
                return false;
            }
            accountDict[username].logIn(username, password);
            return accountDict[username].isAccountLoggedIn();
        }
    }
}
