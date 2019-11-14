using CVeator.Data;
using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeatorServices
{
    public class CVsServices
    {
        public List<PersonalInfo> GetAllCVs()
        {
            CVeatorContext context = new CVeatorContext();
            return context.PersonalInfos.ToList();
        }
        public void SaveCV(PersonalInfo personalInfo)
        {
            CVeatorContext context = new CVeatorContext();
            context.PersonalInfos.Add(personalInfo);
            context.SaveChanges();
        }

        public PersonalInfo GetCVById(int ID)
        {
            CVeatorContext context = new CVeatorContext();
            return context.PersonalInfos.Find(ID);
        }
        public void UpdateCV(PersonalInfo personalInfo)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(personalInfo).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteCV(PersonalInfo personalInfo)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(personalInfo).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
