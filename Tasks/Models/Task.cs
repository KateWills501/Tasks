﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }
    }
}