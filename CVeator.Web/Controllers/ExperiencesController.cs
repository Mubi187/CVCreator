using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeator.Web.ViewModels;
using CVeatorServices;

namespace CVeator.Web.Controllers
{
    public class ExperiencesController : Controller
    {
        Experience Experience = new Experience();
        ExperiencesServices ExperienceServices = new ExperiencesServices();
        public ActionResult Index()
        {
            var AllExperiences = ExperienceServices.GetAllExperience();
            return View(AllExperiences);
        }
        
        public ActionResult Create(int CvID)
        {
            ExperienceViewModel model = new ExperienceViewModel();
            model.PersonalInfo_ID = CvID;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Experience Experience)
        
        {
            ExperienceServices.SaveExperience(Experience);
            return RedirectToAction("Create", "Educations",new {CvID = Experience.PersonalInfo_ID });
        }

        public ActionResult Edit(int ID)
        {
           var Experience = ExperienceServices.GetExperienceById(ID);
            return View(Experience);
        }
        [HttpPost]
        public ActionResult Edit(Experience Experience)
        {
            ExperienceServices.UpdateExperience(Experience);
            return RedirectToAction("index");
        }
        //public ActionResult Delete(int ID)
        //{
        //    var CV = cvServices.GetCVById(ID);
        //    return View(CV);
        //    //return PartialView(auction);
        //}
        [HttpPost]
        public ActionResult Delete(Experience Experience)
        {
            ExperienceServices.DeleteExperience(Experience);
            return RedirectToAction("index");
        }
    }
}