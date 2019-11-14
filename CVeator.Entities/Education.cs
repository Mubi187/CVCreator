using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeator.Entities
{
    public class Education : BaseEntity
    {
        public string SchoolName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Degree { get; set; }
        public string FielOfStudy { get; set; }
        public DateTime GraduationDate { get; set; }

    }
}
