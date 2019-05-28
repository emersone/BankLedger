using LedgerWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LedgerWebApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Index(BankModel model)
        {
            Session[model.username] = model.firstName + " " + model.lastName;

            System.Diagnostics.Debug.WriteLine(model.username + " In Index");

            System.Diagnostics.Debug.WriteLine((string) Session[model.username] + " Here");
            return View();
        }

        public ActionResult About(BankModel model)
        {
            ViewBag.Message = "Your application description page.";
   
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}