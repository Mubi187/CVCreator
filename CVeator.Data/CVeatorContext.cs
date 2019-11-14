using CVeator.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CVeator.Data
{
    public class CVeatorContext : DbContext
    {
        public CVeatorContext() : base("name=CVeatorConnectionString")
        {
        }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Summery> Summeries { get; set; }


    }
}
