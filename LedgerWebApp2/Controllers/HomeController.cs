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
        //Static dictionary to hold semi-persistent account information.
        //Using sessions was also considered for this aspect of the program.
        //This is NOT an ideal solution; a database/persistent storage would be better practice.
        static private Dictionary<String, Account> accountDict = new Dictionary<String, Account>();


        //Get request that checks the user's balance, and formats it appropriately.
        [Authorize]
        [HttpGet]
        public IActionResult CheckBalance()
        {
            string username = Request.Cookies["user"];

            //Format output for balance if balance is negative.
            //Example output: -$500.00 (instead of negative dollar default: ($500.00))
            //Source: https://dzone.com/articles/display-and-format-negative
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            CultureInfo newCulture = new CultureInfo(currentCulture.Name);
            newCulture.NumberFormat.CurrencyNegativePattern = 1;
            Thread.CurrentThread.CurrentCulture = newCulture;

            ViewBag.Balance = String.Format("{0:C}", accountDict[username].checkBalance());
            return View();
        }

        //Get request returns view so user can record a deposit.
        [Authorize]
        [HttpGet]
        public IActionResult RecordDeposit()
        {
            return View();
        }

        //Post request records deposit information from user and saves info to their account.
        [Authorize]
        [HttpPost]
        public IActionResult RecordDeposit(RecordTransactionModel model)
        {
            string username = Request.Cookies["user"];
            System.Diagnostics.Debug.WriteLine(username);
            System.Diagnostics.Debug.WriteLine(accountDict.Keys.Count);

            accountDict[username].recordDeposit(model.Amount);
            return Redirect("/");
        }

        //Get request returns view so user can record a withdrawal.
        [Authorize]
        [HttpGet]
        public IActionResult RecordWithdrawal()
        {
            return View();
        }

        //Post request records withdrawal information from user and saves info to their account.
        [Authorize]
        [HttpPost]
        public IActionResult RecordWithdrawal(RecordTransactionModel model)
        {
            string username = Request.Cookies["user"];
            accountDict[username].recordWithdrawal(model.Amount);
            return Redirect("/");
        }

        //Get request loops through all transactions in a user's account to display to them.
        [Authorize]
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

        //Get request returns view so a new user can create an account.
        [HttpGet]
        public IActionResult CreateAccount()
        {
            return View();
        }

        //Post request creates a new account and adds user info to Account dictionary.
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

            //Redirect user with newly created account to Login page.
            return Redirect("Login");
        }

        //Get request returns view so a user with an account can login.
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        //Post request handles user login by tracking cookies.
        //User's username is appended to their cookie and stored as a cookie to track them.
        //This is NOT an ideal solution; a database to easily track users would be better.
        //Source 1: https://docs.microsoft.com/en-us/aspnet/core/security/authentication/cookie?view=aspnetcore-2.2
        //Source 2: https://dotnetcoretutorials.com/2017/09/16/cookie-authentication-asp-net-core-2-0/
        //Source 3: https://www.c-sharpcorner.com/article/asp-net-core-working-with-cookie/
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

                //Store the current user's username as a cookie.
                Response.Cookies.Append("user", loginModel.username);

                //Just redirect to our index after logging in.
                return Redirect("/");
            }
            ViewBag.LoginError = "Error. Your username and password combination is incorrect.";
            return View();
        }

        //Logs out a user when they choose to logout.
        [Authorize]
        public IActionResult Logout()
        {
            string username = Request.Cookies["user"];

            accountDict[username].logOut();
            HttpContext.SignOutAsync();
            return Redirect("Login");
        }

        //Requires username cookie to be present in order to allow access to ledger action page (index).
       //Returns user to the login page if no such cookie is detected.
        [Authorize]
        public IActionResult Index()
        {
            if (!Request.Cookies.ContainsKey("user"))
            {
                return Redirect("/Home/Login");
            }
            return View();
        }

        //Boolean method sets whether user is logged in or not.
        private bool LoginUser(string username, string password)
        {
            //Check that user's account exists in Account dictionary.
            //Return false if it is not found.
            if (!accountDict.ContainsKey(username))
            {
                return false;
            }
            //Login user.
            accountDict[username].logIn(username, password);
            return accountDict[username].isAccountLoggedIn();
        }
    }
}
