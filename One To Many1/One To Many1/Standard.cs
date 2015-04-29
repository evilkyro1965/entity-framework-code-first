﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_To_Many1
{
    public class Standard
    {
        public Standard()
        {
            Students = new List<Student>();
        }

        public int StandardId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
