﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Doctors
    {
        public int ID_Doctor { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string middle_name { get; set; }
        public int ID_specialty { get; set; }
    }
}