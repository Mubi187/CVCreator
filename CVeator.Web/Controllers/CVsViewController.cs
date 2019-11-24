using CVeator.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeatorServices;

namespace CVeator.Web.Controllers
{
    public class CVsViewController : Controller
    {
        CVsServices cVsServices = new CVsServices();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CV1(int ID)
        {
            CVPreview model = new CVPreview();
            model.CV = cVsServices.GetCVById(ID);
            return View(model);
        }
    }
}