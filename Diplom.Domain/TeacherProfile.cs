﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class TeacherProfile
    {
        public Sella Sella { get; set; }
        public string Post { get; set; }
        public string AcademicDegree { get; set; }
        public string ScientificTitle { get; set; }
        public string Discipline { get; set; }
        public string InfoScientificTitle { get; set; }
        public string ScientificInterests { get; set; }
        public string Contacts { get; set; }
        public bool IsActive { get; set; }
    }
}