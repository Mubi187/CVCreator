using CVeator.Data;
using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeatorServices
{
    public class SummeriesServices
    {
        public List<Summery> GetAllSummeries()
        {
            CVeatorContext context = new CVeatorContext();
            return context.Summeries.ToList();
        }
        public void SaveSummery(Summery Summery)
        {
            CVeatorContext context = new CVeatorContext();
            context.Summeries.Add(Summery);
            context.SaveChanges();
        }

        public Summery GetSummeryById(int ID)
        {
            CVeatorContext context = new CVeatorContext();
            return context.Summeries.Find(ID);
        }
        public void UpdateSummery(Summery Summery)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Summery).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteSummery(Summery Summery)
        {
            CVeatorContext context = new CVeatorContext();
            context.Entry(Summery).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
