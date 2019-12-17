﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using CVeator.Entities;

namespace CVeator.Web.ViewModels
{
    public class SkillsViewModel
    {

        public string SkillName { get; set; }
        public string level { get; set; }


        public int PersonalInfo_ID { get; set; }

        [ForeignKey("PersonalInfo_ID")]
        public virtual PersonalInfo personalInfo { get; set; }
    }

}