using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeator.Entities
{
    public class PersonalInfo : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public Decimal PhoneNumber { get; set; }
        public string PictureURL { get; set; }

        public virtual List<Experience> Experiences { get; set; }
        public virtual List<Education> Educations { get; set; }
        public virtual List<Skill> Skills { get; set; }
        public virtual List<Summery> Summeries { get; set; }



    }
}
