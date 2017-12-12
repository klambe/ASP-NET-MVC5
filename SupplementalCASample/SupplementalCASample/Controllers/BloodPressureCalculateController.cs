using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SupplementalCASample.Models;

namespace SupplementalCASample.Controllers
{
    public class BloodPressureCalculateController : Controller
    {
        // GET: BloodPressureCalculate
        [HttpGet]
        public ActionResult Calculate()
        {
            BloodPressure b1 = new BloodPressure();
            b1.DiastolicPressure = 60;
            b1.SystolicPressure = 100;
            b1.UserBloodPressure = b1.CalculateBloodPressurecategory();

            return View(b1);
        }

        [HttpPost]
        public ActionResult Calculate(BloodPressure b1)
        {

            b1.UserBloodPressure = b1.CalculateBloodPressurecategory();
            return View(b1);
        }
    }
}