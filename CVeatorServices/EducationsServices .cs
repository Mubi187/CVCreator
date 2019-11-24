using CVeator.Data;
using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeatorServices
{
    public class EducationsServices
    {
        public List<Education> GetAllEducation()
        {
            CVeatorContext context = new CVeatorContext();
            return context.Educations.ToList();
        }
        public void SaveEducation(Education Education)
        {
            CVeatorContext context = new CVeatorContext();
            context.Educations.Add(Education);
            context.SaveChanges();
        }

        public Education GetEducationById(int ID)
        {
            CVeatorContext context = new CVeatorContext();
            return context.Educations.Find(ID);
        }
        public void UpdateEducation(Education Education)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Education).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteEducation(Education Education)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Education).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
