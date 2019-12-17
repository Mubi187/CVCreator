using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using CVeator.Entities;

namespace CVeator.Web.ViewModels
{
    public class EducationViewModel
    {


        public string SchoolName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Degree { get; set; }
        public string FielOfStudy { get; set; }
        public DateTime GraduationDate { get; set; }


        public int PersonalInfo_ID { get; set; }

        [ForeignKey("PersonalInfo_ID")]
        public virtual PersonalInfo personalInfo { get; set; }
    }

}