﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppExample.Models
{
    public class JobApplication
    {

        public Applicant? Applicant { get; set; }

        public int YearsOfExperience { get; set; }

        public List<string>? TechStackList { get; set; }
    }
}
