﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeator.Web.ViewModels;
using CVeatorServices;

namespace CVeator.Web.Controllers
{
    public class EducationsController : Controller
    {
        EducationsServices EducationsServices = new EducationsServices();
        public ActionResult Index()
        {
            var AllEducations = EducationsServices.GetAllEducation();
            return View(AllEducations);
        }
        
        public ActionResult Create(int CvID)
        {
            EducationViewModel model = new EducationViewModel();
            model.PersonalInfo_ID = CvID;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Education Education)
        {
            EducationsServices.SaveEducation(Education);
            return RedirectToAction("Create", "Skills", new { CvID = Education.PersonalInfo_ID });
        }

        public ActionResult Edit(int ID)
        {
           var Education = EducationsServices.GetEducationById(ID);
            return View(Education);
        }
        [HttpPost]
        public ActionResult Edit(Education Education)
        {
            EducationsServices.UpdateEducation(Education);
            return RedirectToAction("index");
        }
        //public ActionResult Delete(int ID)
        //{
        //    var CV = cvServices.GetCVById(ID);
        //    return View(CV);
        //    //return PartialView(auction);
        //}
        [HttpPost]
        public ActionResult Delete(Education Education)
        {
            EducationsServices.DeleteEducation(Education);
            return RedirectToAction("index");
        }
    }
}