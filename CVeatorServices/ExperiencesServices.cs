using CVeator.Data;
using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeatorServices
{
    public class ExperiencesServices
    {
        public List<Experience> GetAllExperience()
        {
            CVeatorContext context = new CVeatorContext();
            return context.Experiences.ToList();
        }
        public void SaveExperience(Experience Experience)
        {
            CVeatorContext context = new CVeatorContext();
            context.Experiences.Add(Experience);
            context.SaveChanges();
        }

        public Experience GetExperienceById(int ID)
        {
            CVeatorContext context = new CVeatorContext();
            return context.Experiences.Find(ID);
        }
        public void UpdateExperience(Experience experience)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(experience).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteExperience(Experience experience)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(experience).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
