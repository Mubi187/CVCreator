using CVeator.Data;
using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeatorServices
{
    public class SkillsServices
    {
        public List<Skill> GetAllSkill()
        {
            CVeatorContext context = new CVeatorContext();
            return context.Skills.ToList();
        }
        public void SaveSkill(Skill Skill)
        {
            CVeatorContext context = new CVeatorContext();
            context.Skills.Add(Skill);
            context.SaveChanges();
        }

        public Skill GetSkillById(int ID)
        {
            CVeatorContext context = new CVeatorContext();
            return context.Skills.Find(ID);
        }
        public void UpdateSkill(Skill Skill)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Skill).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteSkill(Skill Skill)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Skill).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
