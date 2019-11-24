using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using CVeator.Entities;

namespace CVeator.Web.ViewModels
{
    public class ExperienceViewModel
    {

        public String Employer { get; set; }
        public String JobTitle { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public String Description { get; set; }


        public int PersonalInfo_ID { get; set; }

        [ForeignKey("PersonalInfo_ID")]
        public virtual PersonalInfo personalInfo { get; set; }
    }

}