﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud_Operation.Models
{
    public class student
    {
        public int id { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string department { get; set; }
        public string choice { get; set; }
    }
}