using PremiumCalculatorApp.Enums;
using PremiumCalculatorApp.Models;
using PremiumCalculatorApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremiumCalculatorApp.Controllers
{
    public class PremiumCalculatorController : Controller
    {
        private CalculatorFactory calObj;
        public PremiumCalculatorController()
        {
            calObj = new ConcreteCalculator();
        }
        public ActionResult Index()
        {
            return View();
        }

        //[ValidateAntiForgeryToken]
        public JsonResult CalculatePremium(PremiumModel model)
        {
            IPremiumCalculator premiumCalculator = null;
            if (!ModelState.IsValid)
            {
                var errorList = ModelState.Values.SelectMany(m => m.Errors)
                                 .Select(e => e.ErrorMessage)
                                 .ToList();
                return Json(new { Error = errorList });
            }
            else
            {
                premiumCalculator = calObj.GetPremium(Enum.GetName(typeof(Occupation), model.Occupation));
                var res = premiumCalculator.CalculateMonthlyPremium(model.SumInsured, model.Age);
                return Json(new { Premium = "Calculated premium: $" + res });
            }
        }
    }
}