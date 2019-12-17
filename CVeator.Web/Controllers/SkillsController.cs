using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVeator.Entities;
using CVeatorServices;
using CVeator.Web.ViewModels;

namespace CVeator.Web.Controllers
{
    public class SkillsController : Controller
    {
        SkillsServices SkillsServices = new SkillsServices();
        public ActionResult Index()
        {
            var AllSkill = SkillsServices.GetAllSkill();
            return View(AllSkill);
        }
        
        public ActionResult Create(int CvID)
        {
            SkillsViewModel model = new SkillsViewModel();
            model.PersonalInfo_ID = CvID;
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(Skill Skill)
        {
            SkillsServices.SaveSkill(Skill);
            return RedirectToAction("Create", "Summeries", new { CvID = Skill.PersonalInfo_ID });
        }

        public ActionResult Edit(int ID)
        {
           var Skill = SkillsServices.GetSkillById(ID);
            return View(Skill);
        }
        [HttpPost]
        public ActionResult Edit(Skill Skill)
        {
            SkillsServices.UpdateSkill(Skill);
            return RedirectToAction("index");
        }
        //public ActionResult Delete(int ID)
        //{
        //    var CV = cvServices.GetCVById(ID);
        //    return View(CV);
        //    //return PartialView(auction);
        //}
        [HttpPost]
        public ActionResult Delete(Skill Skill)
        {
            SkillsServices.DeleteSkill(Skill);
            return RedirectToAction("index");
        }
    }
}