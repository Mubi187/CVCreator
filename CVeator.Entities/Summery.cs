using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVeator.Entities
{
    public class Summery : BaseEntity
    {
        public string ProfessionalSummery { get; set; }


        public int PersonalInfo_ID { get; set; }

        [ForeignKey("PersonalInfo_ID")]
        public virtual PersonalInfo personalInfo { get; set; }
    }
}
