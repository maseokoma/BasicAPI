﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicStudentsDataAPI.Models
{
    public class Student
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string Lastname { get; set; } = "";
    }
}