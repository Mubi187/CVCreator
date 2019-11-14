using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeator.Entities
{
    public class Experience : BaseEntity
    {
        public String Employer { get; set; }
        public String JobTitle { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String Description { get; set; }
    }
}
